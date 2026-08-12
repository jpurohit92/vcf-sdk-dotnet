# Vcenter.Automation.OpenApi.Api.VcenterResourcePoolApi

All URIs are relative to *https://localhost/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VcenterResourcePoolCreate**](VcenterResourcePoolApi.md#vcenterresourcepoolcreate) | **POST** /vcenter/resource-pool |  |
| [**VcenterResourcePoolDelete**](VcenterResourcePoolApi.md#vcenterresourcepooldelete) | **DELETE** /vcenter/resource-pool/{resourcePool} |  |
| [**VcenterResourcePoolGet**](VcenterResourcePoolApi.md#vcenterresourcepoolget) | **GET** /vcenter/resource-pool/{resourcePool} |  |
| [**VcenterResourcePoolList**](VcenterResourcePoolApi.md#vcenterresourcepoollist) | **GET** /vcenter/resource-pool |  |
| [**VcenterResourcePoolUpdate**](VcenterResourcePoolApi.md#vcenterresourcepoolupdate) | **PATCH** /vcenter/resource-pool/{resourcePool} |  |

<a id="vcenterresourcepoolcreate"></a>
# **VcenterResourcePoolCreate**
> string VcenterResourcePoolCreate (VcenterResourcePoolCreateSpec vcenterResourcePoolCreateSpec)



Creates a resource pool.  This operation was added in __vSphere API 7.0.0.0__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `ResourcePool` referenced by the property *Vcenter.ResourcePool.CreateSpec.parent* requires `Resource.CreatePool`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterResourcePoolCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterResourcePoolApi(config);
            var vcenterResourcePoolCreateSpec = new VcenterResourcePoolCreateSpec(); // VcenterResourcePoolCreateSpec | Specification of the new resource pool to be created, see *Vcenter.ResourcePool.CreateSpec*.

            try
            {
                string result = apiInstance.VcenterResourcePoolCreate(vcenterResourcePoolCreateSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterResourcePoolCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterResourcePoolCreateWithHttpInfo(vcenterResourcePoolCreateSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vcenterResourcePoolCreateSpec** | [**VcenterResourcePoolCreateSpec**](VcenterResourcePoolCreateSpec.md) | Specification of the new resource pool to be created, see *Vcenter.ResourcePool.CreateSpec*. |  |

### Return type

**string**

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | If a parameter passed in the spec is invalid. |  -  |
| **401** | If the user can not be authenticated. |  -  |
| **403** | If the user doesn&#39;t have the required privileges. |  -  |
| **404** | If the resource specified in parent could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** If the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** If the specified resource in parent is not accessible.  ***Vapi.Std.Errors.UnableToAllocateResource*** if any of the resources needed to create the resource pool could not be allocated. |  -  |
| **503** | If the system is unable to communicate with a service to complete the request. |  -  |
| **201** | The identifier of the newly created resource pool.  The response will be an identifier for the resource type: &#x60;ResourcePool&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcenterresourcepooldelete"></a>
# **VcenterResourcePoolDelete**
> void VcenterResourcePoolDelete (string resourcePool)



Deletes a resource pool.  This operation was added in __vSphere API 7.0.0.0__.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterResourcePoolDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterResourcePoolApi(config);
            var resourcePool = "resourcePool_example";  // string | Identifier of the resource pool to be deleted.  The parameter must be an identifier for the resource type: `ResourcePool`.

            try
            {
                apiInstance.VcenterResourcePoolDelete(resourcePool);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterResourcePoolDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VcenterResourcePoolDeleteWithHttpInfo(resourcePool);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourcePool** | **string** | Identifier of the resource pool to be deleted.  The parameter must be an identifier for the resource type: &#x60;ResourcePool&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | If the resource pool is a root resource pool. |  -  |
| **401** | If the user can not be authenticated. |  -  |
| **403** | If the user doesn&#39;t have the required privileges. |  -  |
| **404** | If the resource pool is not found. |  -  |
| **500** | If the system reports an error while responding to the request. |  -  |
| **503** | If the system is unable to communicate with a service to complete the request. |  -  |
| **204** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcenterresourcepoolget"></a>
# **VcenterResourcePoolGet**
> VcenterResourcePoolInfo VcenterResourcePoolGet (string resourcePool)



Retrieves information about the resource pool indicated by resourcePool.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `ResourcePool` referenced by the parameter resourcePool requires `System.Read`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterResourcePoolGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterResourcePoolApi(config);
            var resourcePool = "resourcePool_example";  // string | Identifier of the resource pool for which information should be retrieved.  The parameter must be an identifier for the resource type: `ResourcePool`.

            try
            {
                VcenterResourcePoolInfo result = apiInstance.VcenterResourcePoolGet(resourcePool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterResourcePoolGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VcenterResourcePoolInfo> response = apiInstance.VcenterResourcePoolGetWithHttpInfo(resourcePool);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourcePool** | **string** | Identifier of the resource pool for which information should be retrieved.  The parameter must be an identifier for the resource type: &#x60;ResourcePool&#x60;. |  |

### Return type

[**VcenterResourcePoolInfo**](VcenterResourcePoolInfo.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | If the user can not be authenticated. |  -  |
| **403** | If the user doesn&#39;t have the required privileges. |  -  |
| **404** | If the resource pool indicated by resourcePool does not exist. |  -  |
| **503** | If the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Information about the resource pool. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcenterresourcepoollist"></a>
# **VcenterResourcePoolList**
> List&lt;VcenterResourcePoolSummary&gt; VcenterResourcePoolList (List<string>? resourcePools = null, List<string>? names = null, List<string>? parentResourcePools = null, List<string>? datacenters = null, List<string>? hosts = null, List<string>? clusters = null)



Returns information about at most 1000 visible (subject to permission checks) resource pools in vCenter matching the *Vcenter.ResourcePool.FilterSpec*.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterResourcePoolListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterResourcePoolApi(config);
            var resourcePools = new List<string>?(); // List<string>? | Identifiers of resource pools that can match the filter.  If missing or `null` or empty, resource pools with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `ResourcePool`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `ResourcePool`. (optional) 
            var names = new List<string>?(); // List<string>? | Names that resource pools must have to match the filter (see *Vcenter.ResourcePool.Info.name*).  If missing or `null` or empty, resource pools with any name match the filter. (optional) 
            var parentResourcePools = new List<string>?(); // List<string>? | Resource pools that must contain the resource pool for the resource pool to match the filter.  If missing or `null` or empty, resource pools in any resource pool match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `ResourcePool`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `ResourcePool`. (optional) 
            var datacenters = new List<string>?(); // List<string>? | Datacenters that must contain the resource pool for the resource pool to match the filter.  If missing or `null` or empty, resource pools in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Datacenter`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Datacenter`. (optional) 
            var hosts = new List<string>?(); // List<string>? | Hosts that must contain the resource pool for the resource pool to match the filter.  If missing or `null` or empty, resource pools in any host match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `HostSystem`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `HostSystem`. (optional) 
            var clusters = new List<string>?(); // List<string>? | Clusters that must contain the resource pool for the resource pool to match the filter.  If missing or `null` or empty, resource pools in any cluster match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `ClusterComputeResource`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `ClusterComputeResource`. (optional) 

            try
            {
                List<VcenterResourcePoolSummary> result = apiInstance.VcenterResourcePoolList(resourcePools, names, parentResourcePools, datacenters, hosts, clusters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterResourcePoolListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VcenterResourcePoolSummary>> response = apiInstance.VcenterResourcePoolListWithHttpInfo(resourcePools, names, parentResourcePools, datacenters, hosts, clusters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourcePools** | [**List&lt;string&gt;?**](string.md) | Identifiers of resource pools that can match the filter.  If missing or &#x60;null&#x60; or empty, resource pools with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ResourcePool&#x60;. | [optional]  |
| **names** | [**List&lt;string&gt;?**](string.md) | Names that resource pools must have to match the filter (see *Vcenter.ResourcePool.Info.name*).  If missing or &#x60;null&#x60; or empty, resource pools with any name match the filter. | [optional]  |
| **parentResourcePools** | [**List&lt;string&gt;?**](string.md) | Resource pools that must contain the resource pool for the resource pool to match the filter.  If missing or &#x60;null&#x60; or empty, resource pools in any resource pool match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ResourcePool&#x60;. | [optional]  |
| **datacenters** | [**List&lt;string&gt;?**](string.md) | Datacenters that must contain the resource pool for the resource pool to match the filter.  If missing or &#x60;null&#x60; or empty, resource pools in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datacenter&#x60;. | [optional]  |
| **hosts** | [**List&lt;string&gt;?**](string.md) | Hosts that must contain the resource pool for the resource pool to match the filter.  If missing or &#x60;null&#x60; or empty, resource pools in any host match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional]  |
| **clusters** | [**List&lt;string&gt;?**](string.md) | Clusters that must contain the resource pool for the resource pool to match the filter.  If missing or &#x60;null&#x60; or empty, resource pools in any cluster match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional]  |

### Return type

[**List&lt;VcenterResourcePoolSummary&gt;**](VcenterResourcePoolSummary.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | If the user can not be authenticated. |  -  |
| **403** | If the user doesn&#39;t have the required privileges. |  -  |
| **500** | If more than 1000 resource pools match the *Vcenter.ResourcePool.FilterSpec*. |  -  |
| **503** | If the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Commonly used information about the resource pools matching the *Vcenter.ResourcePool.FilterSpec*. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcenterresourcepoolupdate"></a>
# **VcenterResourcePoolUpdate**
> void VcenterResourcePoolUpdate (string resourcePool, VcenterResourcePoolUpdateSpec vcenterResourcePoolUpdateSpec)



Updates the configuration of a resource pool.  This operation was added in __vSphere API 7.0.0.0__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `ResourcePool` referenced by the parameter resourcePool requires `Resource.EditPool`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterResourcePoolUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterResourcePoolApi(config);
            var resourcePool = "resourcePool_example";  // string | Identifier of the resource pool.  The parameter must be an identifier for the resource type: `ResourcePool`.
            var vcenterResourcePoolUpdateSpec = new VcenterResourcePoolUpdateSpec(); // VcenterResourcePoolUpdateSpec | Specification for updating the configuration of the resource pool.

            try
            {
                apiInstance.VcenterResourcePoolUpdate(resourcePool, vcenterResourcePoolUpdateSpec);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterResourcePoolUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VcenterResourcePoolUpdateWithHttpInfo(resourcePool, vcenterResourcePoolUpdateSpec);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterResourcePoolApi.VcenterResourcePoolUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourcePool** | **string** | Identifier of the resource pool.  The parameter must be an identifier for the resource type: &#x60;ResourcePool&#x60;. |  |
| **vcenterResourcePoolUpdateSpec** | [**VcenterResourcePoolUpdateSpec**](VcenterResourcePoolUpdateSpec.md) | Specification for updating the configuration of the resource pool. |  |

### Return type

void (empty response body)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | If any of the specified parameters is invalid. |  -  |
| **401** | If the user can not be authenticated. |  -  |
| **403** | If the user doesn&#39;t have the required privileges. |  -  |
| **404** | If the resource pool is not found. |  -  |
| **500** | ***Vapi.Std.Errors.Error*** If the system reports an error while responding to the request.  ***Vapi.Std.Errors.UnableToAllocateResource*** If any of the resources needed to reconfigure the resource pool could not be allocated. |  -  |
| **503** | If the system is unable to communicate with a service to complete the request. |  -  |
| **204** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

