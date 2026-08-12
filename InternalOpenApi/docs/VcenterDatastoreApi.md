# Vcenter.Automation.OpenApi.Api.VcenterDatastoreApi

All URIs are relative to *https://localhost/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VcenterDatastoreGet**](VcenterDatastoreApi.md#vcenterdatastoreget) | **GET** /vcenter/datastore/{datastore} |  |
| [**VcenterDatastoreList**](VcenterDatastoreApi.md#vcenterdatastorelist) | **GET** /vcenter/datastore |  |

<a id="vcenterdatastoreget"></a>
# **VcenterDatastoreGet**
> VcenterDatastoreInfo VcenterDatastoreGet (string datastore)



Retrieves information about the datastore indicated by datastore.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterDatastoreGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterDatastoreApi(config);
            var datastore = "datastore_example";  // string | Identifier of the datastore for which information should be retrieved.  The parameter must be an identifier for the resource type: `Datastore`.

            try
            {
                VcenterDatastoreInfo result = apiInstance.VcenterDatastoreGet(datastore);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterDatastoreApi.VcenterDatastoreGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterDatastoreGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VcenterDatastoreInfo> response = apiInstance.VcenterDatastoreGetWithHttpInfo(datastore);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterDatastoreApi.VcenterDatastoreGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **datastore** | **string** | Identifier of the datastore for which information should be retrieved.  The parameter must be an identifier for the resource type: &#x60;Datastore&#x60;. |  |

### Return type

[**VcenterDatastoreInfo**](VcenterDatastoreInfo.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if the datastore indicated by datastore does not exist. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Information about the datastore associated with datastore. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcenterdatastorelist"></a>
# **VcenterDatastoreList**
> List&lt;VcenterDatastoreSummary&gt; VcenterDatastoreList (List<string>? datastores = null, List<string>? names = null, List<string>? types = null, List<string>? folders = null, List<string>? datacenters = null)



Returns information about at most 2500 visible (subject to permission checks) datastores in vCenter matching the *Vcenter.Datastore.FilterSpec*.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterDatastoreListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterDatastoreApi(config);
            var datastores = new List<string>?(); // List<string>? | Identifiers of datastores that can match the filter.  If missing or `null` or empty, datastores with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Datastore`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Datastore`. (optional) 
            var names = new List<string>?(); // List<string>? | Names that datastores must have to match the filter (see *Vcenter.Datastore.Info.name*).  If missing or `null` or empty, datastores with any name match the filter. (optional) 
            var types = new List<string>?(); // List<string>? | Types that datastores must have to match the filter (see *Vcenter.Datastore.Summary.type*).  Possible values:   - `VMFS`: VMware File System (ESX Server only).   - `NFS`: Network file system v3 (linux & esx servers only).   - `NFS41`: Network file system v4.1 (linux & esx servers only).   - `CIFS`: Common Internet File System.   - `VSAN`: Virtual SAN (ESX Server only).   - `VFFS`: Flash Read Cache (ESX Server only).   - `VVOL`: vSphere Virtual Volume (ESX Server only).   For more information see: *Vcenter.Datastore.Type*.  If missing or `null` or empty, datastores with any type match the filter. (optional) 
            var folders = new List<string>?(); // List<string>? | Folders that must contain the datastore for the datastore to match the filter.  If missing or `null` or empty, datastores in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Folder`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Folder`. (optional) 
            var datacenters = new List<string>?(); // List<string>? | Datacenters that must contain the datastore for the datastore to match the filter.  If missing or `null` or empty, datastores in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Datacenter`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Datacenter`. (optional) 

            try
            {
                List<VcenterDatastoreSummary> result = apiInstance.VcenterDatastoreList(datastores, names, types, folders, datacenters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterDatastoreApi.VcenterDatastoreList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterDatastoreListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VcenterDatastoreSummary>> response = apiInstance.VcenterDatastoreListWithHttpInfo(datastores, names, types, folders, datacenters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterDatastoreApi.VcenterDatastoreListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **datastores** | [**List&lt;string&gt;?**](string.md) | Identifiers of datastores that can match the filter.  If missing or &#x60;null&#x60; or empty, datastores with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datastore&#x60;. | [optional]  |
| **names** | [**List&lt;string&gt;?**](string.md) | Names that datastores must have to match the filter (see *Vcenter.Datastore.Info.name*).  If missing or &#x60;null&#x60; or empty, datastores with any name match the filter. | [optional]  |
| **types** | [**List&lt;string&gt;?**](string.md) | Types that datastores must have to match the filter (see *Vcenter.Datastore.Summary.type*).  Possible values:   - &#x60;VMFS&#x60;: VMware File System (ESX Server only).   - &#x60;NFS&#x60;: Network file system v3 (linux &amp; esx servers only).   - &#x60;NFS41&#x60;: Network file system v4.1 (linux &amp; esx servers only).   - &#x60;CIFS&#x60;: Common Internet File System.   - &#x60;VSAN&#x60;: Virtual SAN (ESX Server only).   - &#x60;VFFS&#x60;: Flash Read Cache (ESX Server only).   - &#x60;VVOL&#x60;: vSphere Virtual Volume (ESX Server only).   For more information see: *Vcenter.Datastore.Type*.  If missing or &#x60;null&#x60; or empty, datastores with any type match the filter. | [optional]  |
| **folders** | [**List&lt;string&gt;?**](string.md) | Folders that must contain the datastore for the datastore to match the filter.  If missing or &#x60;null&#x60; or empty, datastores in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Folder&#x60;. | [optional]  |
| **datacenters** | [**List&lt;string&gt;?**](string.md) | Datacenters that must contain the datastore for the datastore to match the filter.  If missing or &#x60;null&#x60; or empty, datastores in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datacenter&#x60;. | [optional]  |

### Return type

[**List&lt;VcenterDatastoreSummary&gt;**](VcenterDatastoreSummary.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | if the *Vcenter.Datastore.FilterSpec.types* property contains a value that is not supported by the server.  if the *Vcenter.Datastore.FilterSpec.types* property contains a value that is not supported by the server. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **500** | if more than 2500 datastores match the *Vcenter.Datastore.FilterSpec*. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Commonly used information about the datastores matching the *Vcenter.Datastore.FilterSpec*. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

