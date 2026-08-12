# Vcenter.Automation.OpenApi.Api.VcenterFolderApi

All URIs are relative to *https://localhost/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VcenterFolderList**](VcenterFolderApi.md#vcenterfolderlist) | **GET** /vcenter/folder |  |

<a id="vcenterfolderlist"></a>
# **VcenterFolderList**
> List&lt;VcenterFolderSummary&gt; VcenterFolderList (VcenterFolderFilterSpec? filter = null, List<string>? folders = null, List<string>? names = null, List<string>? parentFolders = null, List<string>? datacenters = null)



Returns information about at most 1000 visible (subject to permission checks) folders in vCenter matching the *Vcenter.Folder.FilterSpec*.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterFolderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterFolderApi(config);
            var filter = new VcenterFolderFilterSpec?(); // VcenterFolderFilterSpec? | Specification of matching folders for which information should be returned.  If missing or `null`, the behavior is equivalent to a *Vcenter.Folder.FilterSpec* with all properties missing or `null` which means all folders match the filter. (optional) 
            var folders = new List<string>?(); // List<string>? | Identifiers of folders that can match the filter.  If missing or `null` or empty, folders with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Folder`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Folder`. (optional) 
            var names = new List<string>?(); // List<string>? | Names that folders must have to match the filter (see *Vcenter.Folder.Summary.name*).  If missing or `null` or empty, folders with any name match the filter. (optional) 
            var parentFolders = new List<string>?(); // List<string>? | Folders that must contain the folder for the folder to match the filter.  If missing or `null` or empty, folder in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Folder`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Folder`. (optional) 
            var datacenters = new List<string>?(); // List<string>? | Datacenters that must contain the folder for the folder to match the filter.  If missing or `null` or empty, folder in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Datacenter`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Datacenter`. (optional) 

            try
            {
                List<VcenterFolderSummary> result = apiInstance.VcenterFolderList(filter, folders, names, parentFolders, datacenters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterFolderApi.VcenterFolderList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterFolderListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VcenterFolderSummary>> response = apiInstance.VcenterFolderListWithHttpInfo(filter, folders, names, parentFolders, datacenters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterFolderApi.VcenterFolderListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | [**VcenterFolderFilterSpec?**](VcenterFolderFilterSpec?.md) | Specification of matching folders for which information should be returned.  If missing or &#x60;null&#x60;, the behavior is equivalent to a *Vcenter.Folder.FilterSpec* with all properties missing or &#x60;null&#x60; which means all folders match the filter. | [optional]  |
| **folders** | [**List&lt;string&gt;?**](string.md) | Identifiers of folders that can match the filter.  If missing or &#x60;null&#x60; or empty, folders with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Folder&#x60;. | [optional]  |
| **names** | [**List&lt;string&gt;?**](string.md) | Names that folders must have to match the filter (see *Vcenter.Folder.Summary.name*).  If missing or &#x60;null&#x60; or empty, folders with any name match the filter. | [optional]  |
| **parentFolders** | [**List&lt;string&gt;?**](string.md) | Folders that must contain the folder for the folder to match the filter.  If missing or &#x60;null&#x60; or empty, folder in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Folder&#x60;. | [optional]  |
| **datacenters** | [**List&lt;string&gt;?**](string.md) | Datacenters that must contain the folder for the folder to match the filter.  If missing or &#x60;null&#x60; or empty, folder in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datacenter&#x60;. | [optional]  |

### Return type

[**List&lt;VcenterFolderSummary&gt;**](VcenterFolderSummary.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | if the *Vcenter.Folder.FilterSpec.type* property contains a value that is not supported by the server. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **500** | if more than 1000 folders match the *Vcenter.Folder.FilterSpec*. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Commonly used information about the folders matching the *Vcenter.Folder.FilterSpec*. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

