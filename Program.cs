using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// REST SDK Namespaces (Generated into Vcenter.Automation.OpenApi)
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Model;
using RestConfig = Vcenter.Automation.OpenApi.Client.Configuration;
using RestApiException = Vcenter.Automation.OpenApi.Client.ApiException;

// VI/JSON SDK Namespaces (Generated into Vcenter.ViJson.OpenApi)
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

        string vcenterUrl = "https://yourserver";
        string username   = "administrator@vsphere.local";
        string password   = "somePass";

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