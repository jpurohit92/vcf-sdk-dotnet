VMware vSphere .NET 8 SDK Generation & Build Pipeline

This documentation provides a comprehensive, step-by-step walkthrough for configuring, generating, building, and running strongly-typed .NET 8 SDKs for both the VMware vSphere Automation REST API and the vSphere Infrastructure VI/JSON API (Vim25) using OpenAPI Generator and Docker.

## Table of Contents

1. [Overview & Architecture](#1-overview--architecture)
2. [Prerequisites](#2-prerequisites)
3. [Project Directory Setup](#3-project-directory-setup)
4. [Custom OpenAPI Template Setup (ApiClient.mustache)](#4-custom-openapi-template-setup-apiclientmustache)
5. [Automated SDK Generation Script (generateSDK.sh)](#5-automated-sdk-generation-script-generatesdksh)
6. [Project File Configuration (vcf-sdk-dotnet.csproj)](#6-project-file-configuration-vcf-sdk-dotnetcsproj)
7. [Application Implementation (Program.cs)](#7-application-implementation-programcs)
8. [Dockerization (Dockerfile)](#8-dockerization-dockerfile)
9. [Execution & Testing](#9-execution--testing)
10. [Troubleshooting Common Issues](#10-troubleshooting-common-issues)

## 1. Overview 

When interacting with VMware vSphere 8.0+, developers typically interact with two distinct endpoints:

- **vSphere Automation REST API** (`/api`): High-level, RESTful, resource-oriented endpoint for managing inventory (VMs, datastores, folders, resource pools).
- **vSphere Infrastructure VI/JSON API** (`/sdk/vim25/8.0.3.0`): Low-level, full object-model JSON equivalent of traditional Vim25 SOAP calls.

### Why Custom Generation Logic Is Required

By default, standard OpenAPI generators produce C# RestSharp code that encounters serialization failures when interacting with polymorphic vSphere VI/JSON schemas (types inheriting from `AbstractOpenAPISchema`).

- **The Bug:** Standard RestSharp code calls `((AbstractOpenAPISchema)obj).ToJson()`, which returns a raw JSON string. RestSharp then stringifies this payload a second time, sending double-escaped JSON (`"{\"config\": ...}"`) to vCenter, causing severe HTTP 500 JSON syntax errors.
- **The Fix:** We inject a custom Mustache template (`ApiClient.mustache`) during code generation. Our customized `CustomJsonCodec` detects if an object is already a string (or an `AbstractOpenAPISchema`) and bypasses secondary serialization.

## 2. Prerequisites

Ensure the following dependencies are installed on your host system:

- **Java Runtime Environment (JRE):** Java 11 or higher (required by `openapi-generator-cli`).
- **.NET 8.0 SDK** (or higher).
- **Docker Engine / Docker Desktop.**
- **OpenAPI Generator CLI:**

```bash
# macOS via Homebrew
brew install openapi-generator

# npm global installation
npm install @openapitools/openapi-generator-cli -g
```

## 3. Project Directory Setup

Organize your root workspace directory (`vcf-sdk-dotnet`) to follow this exact structure:

```
vcf-sdk-dotnet/
├── resources/
│   ├── vi-json.yaml                   # OpenAPI spec for VI/JSON API
│   └── vcenter.yml        # OpenAPI spec for REST API
├── templates/
│   └── csharp/
│       └── ApiClient.mustache         # Custom serialization template override
├── generateSDK.sh                     # SDK generation shell script
├── Dockerfile                         # Multi-stage container build definition
├── Program.cs                         # Interactive CLI Application entry point
├── vcf-sdk-dotnet.csproj              # Main .NET project file
├── InternalViJson/                    # Generated VI/JSON SDK project directory
└── InternalOpenApi/                   # Generated REST SDK project directory
```

## 4. Custom OpenAPI Template Setup (ApiClient.mustache)

Create a file at `templates/csharp/ApiClient.mustache`. This template overrides the default generator output for `ApiClient.cs` and configures `CustomJsonCodec` with correct namespace placeholders (`{{modelPackage}}` and `{{apiPackage}}`).

```csharp
{{>partial_header}}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers;
using RestSharpMethod = RestSharp.Method;
using FileIO = System.IO.File;
using Polly;
using {{modelPackage}};

namespace {{apiPackage}}
{
    /// <summary>
    /// Custom JSON Codec to handle RestSharp serialization for vSphere OpenAPI models cleanly.
    /// </summary>
    internal class CustomJsonCodec : IRestSerializer, ISerializer, IDeserializer
    {
        private readonly IReadableConfiguration _configuration;
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(IReadableConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        public string Serialize(object obj)
        {
            if (obj == null) return null;

            // FIX 1: Pass raw serialized JSON strings through directly to prevent double-escaping
            if (obj is string strObj)
            {
                return strObj;
            }

            // FIX 2: Call ToJson() directly on polymorphic AbstractOpenAPISchema wrappers
            if (obj is AbstractOpenAPISchema openApiSchema)
            {
                return openApiSchema.ToJson();
            }

            return JsonConvert.SerializeObject(obj, _serializerSettings);
        }

        public string Serialize(Parameter bodyParameter) => Serialize(bodyParameter.Value);

        public T Deserialize<T>(RestResponse response) => (T)Deserialize(response, typeof(T));

        internal object Deserialize(RestResponse response, Type type)
        {
            if (type == typeof(byte[])) return response.RawBytes;

            if (type == typeof(Stream))
            {
                var bytes = response.RawBytes;
                if (response.Headers != null)
                {
                    var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? global::System.IO.Path.GetTempPath()
                        : _configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in response.Headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            FileIO.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                return new MemoryStream(bytes);
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime"))
            {
                return DateTime.Parse(response.Content, null, DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable"))
            {
                return Convert.ChangeType(response.Content, type);
            }

            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public ISerializer Serializer => this;
        public IDeserializer Deserializer => this;
        public string[] AcceptedContentTypes => ContentType.JsonAccept;
        public SupportsContentType SupportsContentType => contentType =>
            contentType.Value.EndsWith("json", StringComparison.InvariantCultureIgnoreCase) ||
            contentType.Value.EndsWith("javascript", StringComparison.InvariantCultureIgnoreCase);

        public ContentType ContentType { get; set; } = ContentType.Json;
        public DataFormat DataFormat => DataFormat.Json;
    }

    public partial class ApiClient : ISynchronousClient, IAsynchronousClient
    {
        private readonly string _baseUrl;

        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy { OverrideSpecifiedNames = false }
            }
        };

        partial void InterceptRequest(RestRequest request);
        partial void InterceptResponse(RestRequest request, RestResponse response);

        public ApiClient() { _baseUrl = GlobalConfiguration.Instance.BasePath; }

        public ApiClient(string basePath)
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");
            _baseUrl = basePath;
        }

        private RestSharpMethod Method(HttpMethod method)
        {
            return method switch
            {
                HttpMethod.Get => RestSharpMethod.Get,
                HttpMethod.Post => RestSharpMethod.Post,
                HttpMethod.Put => RestSharpMethod.Put,
                HttpMethod.Delete => RestSharpMethod.Delete,
                HttpMethod.Head => RestSharpMethod.Head,
                HttpMethod.Options => RestSharpMethod.Options,
                HttpMethod.Patch => RestSharpMethod.Patch,
                _ => throw new ArgumentOutOfRangeException(nameof(method), method, null)
            };
        }

        private RestRequest NewRequest(HttpMethod method, string path, RequestOptions options, IReadableConfiguration configuration)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            RestRequest request = new RestRequest(path, Method(method));

            if (options.PathParameters != null)
                foreach (var param in options.PathParameters)
                    request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            if (options.QueryParameters != null)
                foreach (var param in options.QueryParameters)
                    foreach (var val in param.Value)
                        request.AddQueryParameter(param.Key, val);

            if (configuration.DefaultHeaders != null)
                foreach (var param in configuration.DefaultHeaders)
                    request.AddHeader(param.Key, param.Value);

            if (options.HeaderParameters != null)
                foreach (var param in options.HeaderParameters)
                    foreach (var val in param.Value)
                        request.AddOrUpdateHeader(param.Key, val);

            if (options.FormParameters != null)
                foreach (var param in options.FormParameters)
                    request.AddParameter(param.Key, param.Value);

            if (options.Data != null)
            {
                if (options.Data is Stream stream)
                {
                    var contentType = "application/octet-stream";
                    if (options.HeaderParameters != null && options.HeaderParameters.TryGetValue("Content-Type", out var contentTypes))
                        contentType = contentTypes[0];

                    request.AddParameter(contentType, ClientUtils.ReadAsBytes(stream), ParameterType.RequestBody);
                }
                else
                {
                    request.RequestFormat = DataFormat.Json;
                    request.AddJsonBody(options.Data);
                }
            }

            if (options.FileParameters != null)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    foreach (var file in fileParam.Value)
                    {
                        var bytes = ClientUtils.ReadAsBytes(file);
                        if (file is FileStream fileStream)
                            request.AddFile(fileParam.Key, bytes, global::System.IO.Path.GetFileName(fileStream.Name));
                        else
                            request.AddFile(fileParam.Key, bytes, "no_file_name_provided");
                    }
                }
            }

            return request;
        }

        private ApiResponse<T> ToApiResponse<T>(RestResponse<T> response)
        {
            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), response.Data, response.Content)
            {
                ErrorText = response.ErrorMessage,
                Cookies = new List<Cookie>()
            };

            if (response.Headers != null)
                foreach (var h in response.Headers)
                    transformed.Headers.Add(h.Name, ClientUtils.ParameterToString(h.Value));

            if (response.ContentHeaders != null)
                foreach (var h in response.ContentHeaders)
                    transformed.Headers.Add(h.Name, ClientUtils.ParameterToString(h.Value));

            if (response.Cookies != null)
                foreach (var c in response.Cookies.Cast<Cookie>())
                    transformed.Cookies.Add(new Cookie(c.Name, c.Value, c.Path, c.Domain));

            return transformed;
        }

        private async Task<ApiResponse<T>> ExecClientAsync<T>(Func<RestClient, Task<RestResponse<T>>> getResponse, Action<RestClientOptions> setOptions, RestRequest request, RequestOptions options, IReadableConfiguration configuration)
        {
            var baseUrl = configuration.GetOperationServerUrl(options.Operation, options.OperationIndex) ?? _baseUrl;
            var clientOptions = new RestClientOptions(baseUrl)
            {
                ClientCertificates = configuration.ClientCertificates,
                Timeout = configuration.Timeout,
                Proxy = configuration.Proxy,
                UserAgent = configuration.UserAgent,
                UseDefaultCredentials = configuration.UseDefaultCredentials,
                RemoteCertificateValidationCallback = configuration.RemoteCertificateValidationCallback
            };
            setOptions(clientOptions);

            using (RestClient client = new RestClient(clientOptions,
                configureSerialization: s => s.UseSerializer(() => new CustomJsonCodec(SerializerSettings, configuration))))
            {
                InterceptRequest(request);
                RestResponse<T> response = await getResponse(client).ConfigureAwait(false);

                if (typeof(AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
                {
                    try
                    {
                        response.Data = (T)typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
                    }
                    catch (Exception ex)
                    {
                        throw ex.InnerException ?? ex;
                    }
                }
                else if (typeof(T).Name == "Stream") response.Data = (T)(object)new MemoryStream(response.RawBytes);
                else if (typeof(T).Name == "Byte[]") response.Data = (T)(object)response.RawBytes;
                else if (typeof(T).Name == "String") response.Data = (T)(object)response.Content;

                InterceptResponse(request, response);
                return ToApiResponse(response);
            }
        }

        private async Task<RestResponse<T>> DeserializeRestResponseFromPolicyAsync<T>(RestClient client, RestRequest request, PolicyResult<RestResponse> policyResult, CancellationToken cancellationToken = default)
        {
            if (policyResult.Outcome == OutcomeType.Successful)
                return await client.Deserialize<T>(policyResult.Result, cancellationToken).ConfigureAwait(false);

            return new RestResponse<T>(request) { ErrorException = policyResult.FinalException };
        }

        private Task<ApiResponse<T>> ExecAsync<T>(RestRequest request, RequestOptions options, IReadableConfiguration configuration, CancellationToken cancellationToken = default)
        {
            Func<RestClient, Task<RestResponse<T>>> getResponse = async (client) =>
            {
                if (RetryConfiguration.AsyncRetryPolicy != null)
                {
                    var policyResult = await RetryConfiguration.AsyncRetryPolicy.ExecuteAndCaptureAsync((ct) => client.ExecuteAsync(request, ct), cancellationToken).ConfigureAwait(false);
                    return await DeserializeRestResponseFromPolicyAsync<T>(client, request, policyResult, cancellationToken).ConfigureAwait(false);
                }
                return await client.ExecuteAsync<T>(request, cancellationToken).ConfigureAwait(false);
            };

            return ExecClientAsync(getResponse, _ => {}, request, options, configuration);
        }

        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => ExecAsync<T>(NewRequest(HttpMethod.Get, path, options, configuration ?? GlobalConfiguration.Instance), options, configuration ?? GlobalConfiguration.Instance, cancellationToken);
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => ExecAsync<T>(NewRequest(HttpMethod.Post, path, options, configuration ?? GlobalConfiguration.Instance), options, configuration ?? GlobalConfiguration.Instance, cancellationToken);
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => ExecAsync<T>(NewRequest(HttpMethod.Put, path, options, configuration ?? GlobalConfiguration.Instance), options, configuration ?? GlobalConfiguration.Instance, cancellationToken);
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options, configuration ?? GlobalConfiguration.Instance), options, configuration ?? GlobalConfiguration.Instance, cancellationToken);

        public ApiResponse<T> Get<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => GetAsync<T>(path, options, configuration).GetAwaiter().GetResult();
        public ApiResponse<T> Post<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => PostAsync<T>(path, options, configuration).GetAwaiter().GetResult();
        public ApiResponse<T> Put<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => PutAsync<T>(path, options, configuration).GetAwaiter().GetResult();
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => DeleteAsync<T>(path, options, configuration).GetAwaiter().GetResult();
    }
}
```

## 5. Automated SDK Generation Script (generateSDK.sh)

Create `generateSDK.sh` at the root of your project.

**Key Script Configurations:**

- `_JAVA_OPTIONS="-DmaxYamlCodePoints=99999999"`: Increases SnakeYAML's code point limit from the default 3MB to allow parsing massive vSphere YAML files without crashing.
- `--global-property apis="..."`: Filters the generator output to compile only the API modules required for our project, dramatically lowering compile times and output footprint.
- `-t templates/csharp`: Instructs the generator to load our custom `ApiClient.mustache`.

```bash
#!/usr/bin/env bash
set -e

echo "--> Cleaning output directories..."
rm -rf ./InternalViJson ./InternalOpenApi

echo "--> Generating VI/JSON SDK..."
_JAVA_OPTIONS="-DmaxYamlCodePoints=99999999" openapi-generator generate \
  -i resources/vi-json.yaml \
  -g csharp \
  -t templates/csharp \
  -o ./InternalViJson \
  --package-name Vcenter.ViJson.OpenApi \
  --additional-properties targetFramework=net8.0,library=restsharp,useOneOfDiscriminatorLookup=true,nullableReferenceTypes=true \
  --global-property apis="SessionManager:Folder:VirtualMachine",models,supportingFiles,tests=false \
  --skip-validate-spec

echo "--> Generating REST SDK..."
_JAVA_OPTIONS="-DmaxYamlCodePoints=99999999" openapi-generator generate \
  -i resources/vsphere-automation.yaml \
  -g csharp \
  -o ./InternalOpenApi \
  --package-name Vcenter.Automation.OpenApi \
  --additional-properties targetFramework=net8.0,library=restsharp,nullableReferenceTypes=true \
  --global-property apis="CisSession:VcenterDatastore:VcenterFolder:VcenterResourcePool:VcenterVM",models,supportingFiles,tests=false \
  --skip-validate-spec

echo "SDK Generation Completed!"
```

Grant executable permissions:

```bash
chmod +x generateSDK.sh
```

## 6. Project File Configuration (vcf-sdk-dotnet.csproj)

Configure your main project file `vcf-sdk-dotnet.csproj` to reference both generated client libraries:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <RootNamespace>VcfSdkDotnet</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="InternalViJson/src/Vcenter.ViJson.OpenApi/Vcenter.ViJson.OpenApi.csproj" />
    <ProjectReference Include="InternalOpenApi/src/Vcenter.Automation.OpenApi/Vcenter.Automation.OpenApi.csproj" />
  </ItemGroup>

</Project>
```

## 7. Application Implementation (Program.cs)

Here is the complete `Program.cs` implementing interactive terminal options for both REST and VI/JSON API operations using strongly-typed SDK calls:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// REST SDK Namespaces
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Model;
using RestConfig = Vcenter.Automation.OpenApi.Client.Configuration;
using RestApiException = Vcenter.Automation.OpenApi.Client.ApiException;

// VI/JSON SDK Namespaces
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Model;
using ViJsonConfig = Vcenter.ViJson.OpenApi.Client.Configuration;
using ViJsonApiException = Vcenter.ViJson.OpenApi.Client.ApiException;

class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("        VMware vSphere SDK .NET Demo Menu         ");
            Console.WriteLine("==================================================");
            Console.WriteLine("  1. Run REST API Demo (Create VM & List VMs)");
            Console.WriteLine("  2. Run VI/JSON API Demo (Create VM & Take Snapshot)");
            Console.WriteLine("  0. Exit");
            Console.WriteLine("==================================================");
            Console.Write("Select an option [0-2]: ");

            string choice = Console.ReadLine()?.Trim();

            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    await RunRestApiDemoAsync();
                    break;
                case "2":
                    await RunViJsonApiDemoAsync();
                    break;
                case "0":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press Any key to try again...");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine("\nPress Any key to return to the main menu...");
            Console.ReadKey();
        }
    }

    // =========================================================================
    // OPTION 1: REST API DEMO (Using InternalOpenApi)
    // =========================================================================
    private static async Task RunRestApiDemoAsync()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("               REST API DEMO                      ");
        Console.WriteLine("==================================================");

        string vcenterUrl = "https://holovc01.holo.lab/api";
        string username   = "administrator@vsphere.local";
        string password   = "VMware1!";

        var authConfig = new RestConfig
        {
            BasePath = vcenterUrl,
            Username = username,
            Password = password,
            RemoteCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
        };

        var sessionApi = new CisSessionApi(authConfig);

        try
        {
            Console.WriteLine("--> Authenticating with vCenter REST endpoint...");
            string sessionToken = await sessionApi.CisSessionCreateAsync();

            if (string.IsNullOrEmpty(sessionToken))
            {
                Console.WriteLine("[FAILED] Received empty session token.");
                return;
            }

            sessionToken = sessionToken.Trim('"');
            Console.WriteLine($"[SUCCESS] Session Token: {sessionToken}");

            var tokenConfig = new RestConfig
            {
                BasePath = vcenterUrl,
                RemoteCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };
            tokenConfig.DefaultHeaders["vmware-api-session-id"] = sessionToken;

            var vmApi           = new VcenterVMApi(tokenConfig);
            var folderApi       = new VcenterFolderApi(tokenConfig);
            var datastoreApi    = new VcenterDatastoreApi(tokenConfig);
            var resourcePoolApi = new VcenterResourcePoolApi(tokenConfig);

            Console.WriteLine("\n--> Discovering inventory resources for VM placement...");

            var folders = await folderApi.VcenterFolderListAsync();
            if (folders == null || folders.Count == 0)
            {
                Console.WriteLine("[ERROR] No VM folders found in vCenter.");
                return;
            }
            string folderId = folders[0].Folder;
            Console.WriteLine($"[FOUND] Folder: {folders[0].Name} ({folderId})");

            var datastores = await datastoreApi.VcenterDatastoreListAsync();
            if (datastores == null || datastores.Count == 0)
            {
                Console.WriteLine("[ERROR] No datastores found in vCenter.");
                return;
            }
            string datastoreId = datastores[0].Datastore;
            Console.WriteLine($"[FOUND] Datastore: {datastores[0].Name} ({datastoreId})");

            var resourcePools = await resourcePoolApi.VcenterResourcePoolListAsync();
            if (resourcePools == null || resourcePools.Count == 0)
            {
                Console.WriteLine("[ERROR] No resource pools found in vCenter.");
                return;
            }
            string resourcePoolId = resourcePools[0].ResourcePool;
            Console.WriteLine($"[FOUND] Resource Pool ID: {resourcePoolId}");

            string newVmName = $"REST-Demo-VM-{Guid.NewGuid().ToString().Substring(0, 5)}";
            Console.WriteLine($"\n--> Preparing VM Creation Spec for: '{newVmName}'...");

            var placement = new VcenterVMPlacementSpec(
                folder: folderId,
                datastore: datastoreId,
                resourcePool: resourcePoolId
            );

            var createSpec = new VcenterVMCreateSpec(
                guestOs: "RHEL_8_64",
                name: newVmName,
                placement: placement
            );

            Console.WriteLine("--> Executing VcenterVMCreateAsync...");
            string newVmId = await vmApi.VcenterVMCreateAsync(createSpec);
            newVmId = newVmId?.Trim('"') ?? string.Empty;
            Console.WriteLine($"\n[SUCCESS] VM Created Successfully! New VM ID: {newVmId}");

            Console.WriteLine("\n--> Fetching updated VM list...");
            var vms = await vmApi.VcenterVMListAsync();

            Console.WriteLine($"\nFound {vms.Count} Virtual Machine(s):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{"VM ID",-15} | {"NAME",-30} | {"POWER STATE",-15}");
            Console.WriteLine(new string('-', 70));

            foreach (var vm in vms)
            {
                Console.WriteLine($"{vm.Vm,-15} | {vm.Name,-30} | {vm.PowerState,-15}");
            }
            Console.WriteLine(new string('-', 70));
        }
        catch (RestApiException ex)
        {
            Console.WriteLine($"\n[ERROR] REST API Exception ({ex.ErrorCode}): {ex.Message}");
            Console.WriteLine(ex.ErrorContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERROR] Unexpected error: {ex.Message}");
        }
    }

    // =========================================================================
    // OPTION 2: VI/JSON API DEMO (Using InternalViJson)
    // =========================================================================
    private static async Task RunViJsonApiDemoAsync()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("              VI/JSON API DEMO                    ");
        Console.WriteLine("==================================================");

        string vcenterUrl = "https://holovc01.holo.lab/sdk/vim25/8.0.3.0";
        string username   = "administrator@vsphere.local";
        string password   = "VMware1!";

        string folderMoRefValue       = "group-v3030";        // Target VM Folder MoRef ID
        string resourcePoolMoRefValue = "resgroup-10";      // Target Resource Pool MoRef ID
        string datastoreName          = "[vsanDatastore]";  // Target Datastore bracketed name

        var config = new ViJsonConfig
        {
            BasePath = vcenterUrl,
            RemoteCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
        };

        var sessionManagerApi = new SessionManagerApi(config);

        try
        {
            Console.WriteLine("--> Logging in to VI/JSON endpoint via SessionManager...");

            var loginRequest = new LoginRequestType(
                userName: username,
                password: password,
                locale: "en_US"
            );

            var loginResponse = await sessionManagerApi.SessionManagerLoginWithHttpInfoAsync(
                "SessionManager",
                loginRequest
            );

            var userSession = loginResponse.Data;
            Console.WriteLine($"[SUCCESS] Logged in as: {userSession.UserName}");

            if (loginResponse.Headers.TryGetValue("vmware-api-session-id", out var sessionHeader))
            {
                string sessionId = sessionHeader.FirstOrDefault();
                config.DefaultHeaders["vmware-api-session-id"] = sessionId;
                config.ApiKey["vmware-api-session-id"] = sessionId;
            }

            if (loginResponse.Headers.TryGetValue("Set-Cookie", out var cookieHeader))
            {
                config.DefaultHeaders["Cookie"] = cookieHeader.FirstOrDefault();
            }

            // STEP 2: Create VM using strongly-typed SDK models and methods
            string newVmName = $"VIJSON-Demo-VM-{Guid.NewGuid().ToString().Substring(0, 5)}";
            Console.WriteLine($"\n--> Initiating VM Creation for: '{newVmName}'...");

            var folderApi = new FolderApi(config);

            // Construct SDK FileInfo object
            var vmFileInfo = new VirtualMachineFileInfo
            {
                VmPathName = datastoreName
            };

            // Construct SDK ConfigSpec object
            var vmConfigSpec = new VirtualMachineConfigSpec
            {
                Name = newVmName,
                GuestId = "rhel8_64Guest",
                NumCPUs = 2,
                MemoryMB = 4096,
                Files = vmFileInfo
            };

            // Construct SDK ResourcePool MoRef
            var resourcePoolMoRef = new ManagedObjectReference(
                value: resourcePoolMoRefValue,
                type: "ResourcePool"
            );

            // Construct strongly-typed SDK request wrapper
            var createVmRequest = new CreateVMRequestType(
                config: vmConfigSpec,
                pool: resourcePoolMoRef
            );

            Console.WriteLine("--> Executing FolderApi.FolderCreateVMTaskAsync via SDK...");

            // Native, strongly-typed SDK call
            var taskMoRef = await folderApi.FolderCreateVMTaskAsync(
                folderMoRefValue,
                createVmRequest
            );

            Console.WriteLine($"\n[SUCCESS] CreateVM Task Initiated via SDK! Task MoRef: {taskMoRef.Value}");
        }
        catch (ViJsonApiException ex)
        {
            Console.WriteLine($"\n[ERROR] VI/JSON API Exception ({ex.ErrorCode}): {ex.Message}");
            Console.WriteLine(ex.ErrorContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n[ERROR] Unexpected error: {ex.Message}");
        }
    }
}
```

## 8. Dockerization (Dockerfile)

Create a `Dockerfile` in your project root using a multi-stage build approach:

```dockerfile
# Step 1: Build stage using .NET 8 SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files and generated SDK source directories
COPY ["vcf-sdk-dotnet.csproj", "./"]
COPY ["InternalOpenApi/", "InternalOpenApi/"]
COPY ["InternalViJson/", "InternalViJson/"]
RUN dotnet restore "vcf-sdk-dotnet.csproj"

# Copy main application source code
COPY . .

# Publish Release build
RUN dotnet publish "vcf-sdk-dotnet.csproj" -c Release -o /app/publish /p:UseAppHost=false /p:WarningLevel=0 /clp:ErrorsOnly

# Step 2: Final runtime stage using slim ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "vcf-sdk-dotnet.dll"]
```

## 9. Execution & Testing

Follow these steps sequentially to generate, build, and execute the application:

### Step 9.1: Generate SDKs

```bash
./generateSDK.sh
```

### Step 9.2: Option A — Local Host Execution (.NET CLI)

```bash
dotnet restore
dotnet build
dotnet run
```

### Step 9.3: Option B — Containerized Execution (Docker)

Build the image with `--no-cache` to ensure the container picks up freshly generated SDK folders:

```bash
# Build the Docker image
docker build --no-cache -t vcf-sdk-app:8.0 .

# Run the interactive application container
docker run -it --rm vcf-sdk-app:8.0
```

## 10. Troubleshooting Common Issues

| Error Message / Symptom | Root Cause | Resolution |
|---|---|---|
| `zsh: permission denied: ./generateSDK.sh` | Shell script lacks execution flags. | Run `chmod +x generateSDK.sh`. |
| `The incoming YAML document exceeds the limit: 3145728 code points.` | SnakeYAML size limit exceeded on large OpenAPI specs. | Ensure `_JAVA_OPTIONS="-DmaxYamlCodePoints=99999999"` is set in `generateSDK.sh`. |
| `CS0246: The type or namespace name 'Model' could not be found` | Hardcoded namespace names inside template files. | Use Mustache tags `using {{modelPackage}};` and `namespace {{apiPackage}}` in `ApiClient.mustache`. |
| `error CS0246: Project reference not found` | Folder path mismatch in `.csproj`. | Verify that `.csproj` references `./InternalOpenApi` and `./InternalViJson` matching output paths in `generateSDK.sh`. |
| `Unexpected non-whitespace character after JSON text` (vCenter 500) | Double-stringification of raw JSON in RestSharp. | Ensure `if (obj is string strObj) return strObj;` is active in `ApiClient.mustache`. |
