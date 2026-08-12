# Vcenter.Automation.OpenApi.Api.VcenterVMApi

All URIs are relative to *https://localhost/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VcenterVMClone**](VcenterVMApi.md#vcentervmclone) | **POST** /vcenter/vm?action&#x3D;clone |  |
| [**VcenterVMCloneTask**](VcenterVMApi.md#vcentervmclonetask) | **POST** /vcenter/vm?action&#x3D;clone&amp;vmw-task&#x3D;true |  |
| [**VcenterVMCreate**](VcenterVMApi.md#vcentervmcreate) | **POST** /vcenter/vm |  |
| [**VcenterVMDelete**](VcenterVMApi.md#vcentervmdelete) | **DELETE** /vcenter/vm/{vm} |  |
| [**VcenterVMGet**](VcenterVMApi.md#vcentervmget) | **GET** /vcenter/vm/{vm} |  |
| [**VcenterVMInstantClone**](VcenterVMApi.md#vcentervminstantclone) | **POST** /vcenter/vm?action&#x3D;instant-clone |  |
| [**VcenterVMList**](VcenterVMApi.md#vcentervmlist) | **GET** /vcenter/vm |  |
| [**VcenterVMRegister**](VcenterVMApi.md#vcentervmregister) | **POST** /vcenter/vm?action&#x3D;register |  |
| [**VcenterVMRelocate**](VcenterVMApi.md#vcentervmrelocate) | **POST** /vcenter/vm/{vm}?action&#x3D;relocate |  |
| [**VcenterVMRelocateTask**](VcenterVMApi.md#vcentervmrelocatetask) | **POST** /vcenter/vm/{vm}?action&#x3D;relocate&amp;vmw-task&#x3D;true |  |
| [**VcenterVMUnregister**](VcenterVMApi.md#vcentervmunregister) | **POST** /vcenter/vm/{vm}?action&#x3D;unregister |  |

<a id="vcentervmclone"></a>
# **VcenterVMClone**
> string VcenterVMClone (VcenterVMCloneSpec vcenterVMCloneSpec)



Creates a virtual machine from an existing virtual machine.     This operation was added in __vSphere API 7.0.0.0__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `Datastore` referenced by the property *Vcenter.VM.DiskCloneSpec.datastore* requires `Datastore.AllocateSpace`.    -  The resource `Datastore` referenced by the property *Vcenter.VM.ClonePlacementSpec.datastore* requires `Datastore.AllocateSpace`.    -  The resource `Folder` referenced by the property *Vcenter.VM.ClonePlacementSpec.folder* requires `VirtualMachine.Inventory.CreateFromExisting`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.ClonePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.    -  The resource `VirtualMachine` referenced by the property *Vcenter.VM.CloneSpec.source* requires `VirtualMachine.Provisioning.Clone`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMCloneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vcenterVMCloneSpec = new VcenterVMCloneSpec(); // VcenterVMCloneSpec | Virtual machine clone specification.

            try
            {
                string result = apiInstance.VcenterVMClone(vcenterVMCloneSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMClone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMCloneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterVMCloneWithHttpInfo(vcenterVMCloneSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMCloneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vcenterVMCloneSpec** | [**VcenterVMCloneSpec**](VcenterVMCloneSpec.md) | Virtual machine clone specification. |  |

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
| **400** | ***Vapi.Std.Errors.AlreadyExists*** if a virtual machine with the specified name already exists.  ***Vapi.Std.Errors.InvalidArgument*** if any of the specified parameters are invalid. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible.  ***Vapi.Std.Errors.UnableToAllocateResource*** if any of the resources needed to clone the virtual machine could not be allocated. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | ID of newly-created virtual machine.  The response will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmclonetask"></a>
# **VcenterVMCloneTask**
> string VcenterVMCloneTask (VcenterVMCloneSpec vcenterVMCloneSpec)



Creates a virtual machine from an existing virtual machine.     This operation was added in __vSphere API 7.0.0.0__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `Datastore` referenced by the property *Vcenter.VM.DiskCloneSpec.datastore* requires `Datastore.AllocateSpace`.    -  The resource `Datastore` referenced by the property *Vcenter.VM.ClonePlacementSpec.datastore* requires `Datastore.AllocateSpace`.    -  The resource `Folder` referenced by the property *Vcenter.VM.ClonePlacementSpec.folder* requires `VirtualMachine.Inventory.CreateFromExisting`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.ClonePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.    -  The resource `VirtualMachine` referenced by the property *Vcenter.VM.CloneSpec.source* requires `VirtualMachine.Provisioning.Clone`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMCloneTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vcenterVMCloneSpec = new VcenterVMCloneSpec(); // VcenterVMCloneSpec | Virtual machine clone specification.

            try
            {
                string result = apiInstance.VcenterVMCloneTask(vcenterVMCloneSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMCloneTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMCloneTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterVMCloneTaskWithHttpInfo(vcenterVMCloneSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMCloneTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vcenterVMCloneSpec** | [**VcenterVMCloneSpec**](VcenterVMCloneSpec.md) | Virtual machine clone specification. |  |

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
| **400** | ***Vapi.Std.Errors.AlreadyExists*** if a virtual machine with the specified name already exists.  ***Vapi.Std.Errors.InvalidArgument*** if any of the specified parameters are invalid. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible.  ***Vapi.Std.Errors.UnableToAllocateResource*** if any of the resources needed to clone the virtual machine could not be allocated. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **202** | ID of newly-created virtual machine.  The response will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmcreate"></a>
# **VcenterVMCreate**
> string VcenterVMCreate (VcenterVMCreateSpec vcenterVMCreateSpec)



Creates a virtual machine.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `Folder` referenced by the property *Vcenter.VM.InventoryPlacementSpec.folder* requires `VirtualMachine.Inventory.Create`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.ComputePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.    -  The resource `Datastore` referenced by the property *Vcenter.VM.StoragePlacementSpec.datastore* requires `Datastore.AllocateSpace`.    -  The resource `Network` referenced by the property *Vcenter.Vm.Hardware.Ethernet.BackingSpec.network* requires `Network.Assign`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vcenterVMCreateSpec = new VcenterVMCreateSpec(); // VcenterVMCreateSpec | Virtual machine specification.

            try
            {
                string result = apiInstance.VcenterVMCreate(vcenterVMCreateSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterVMCreateWithHttpInfo(vcenterVMCreateSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vcenterVMCreateSpec** | [**VcenterVMCreateSpec**](VcenterVMCreateSpec.md) | Virtual machine specification. |  |

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
| **400** | ***Vapi.Std.Errors.AlreadyExists*** if a virtual machine with the specified name already exists.  ***Vapi.Std.Errors.InvalidArgument*** if any of the specified parameters are invalid.  ***Vapi.Std.Errors.ResourceInUse*** if any of the specified storage addresses (eg. IDE, SATA, SCSI, NVMe) result in a storage address conflict.  ***Vapi.Std.Errors.Unsupported*** if guest_OS is not supported for the requested virtual hardware version and spec includes missing or &#x60;null&#x60; properties that default to guest-specific values. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible.  ***Vapi.Std.Errors.UnableToAllocateResource*** if any of the resources needed to create the virtual machine could not be allocated. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **201** | ID of newly-created virtual machine.  The response will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmdelete"></a>
# **VcenterVMDelete**
> void VcenterVMDelete (string vm)



Deletes a virtual machine.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `VirtualMachine` referenced by the parameter vm requires `VirtualMachine.Inventory.Delete`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vm = "vm_example";  // string | Virtual machine identifier.  The parameter must be an identifier for the resource type: `VirtualMachine`.

            try
            {
                apiInstance.VcenterVMDelete(vm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VcenterVMDeleteWithHttpInfo(vm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vm** | **string** | Virtual machine identifier.  The parameter must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  |

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
| **400** | if the virtual machine is running (powered on). |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if the virtual machine is not found. |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceBusy*** if the virtual machine is busy performing another operation.  ***Vapi.Std.Errors.ResourceInaccessible*** if the virtual machine&#39;s configuration state cannot be accessed. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **204** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmget"></a>
# **VcenterVMGet**
> VcenterVMInfo VcenterVMGet (string vm)



Returns information about a virtual machine.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `VirtualMachine` referenced by the parameter vm requires `System.Read`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vm = "vm_example";  // string | Virtual machine identifier.  The parameter must be an identifier for the resource type: `VirtualMachine`.

            try
            {
                VcenterVMInfo result = apiInstance.VcenterVMGet(vm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VcenterVMInfo> response = apiInstance.VcenterVMGetWithHttpInfo(vm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vm** | **string** | Virtual machine identifier.  The parameter must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  |

### Return type

[**VcenterVMInfo**](VcenterVMInfo.md)

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
| **404** | if the virtual machine is not found. |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if the virtual machine&#39;s configuration state cannot be accessed. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Information about the specified virtual machine. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervminstantclone"></a>
# **VcenterVMInstantClone**
> string VcenterVMInstantClone (VcenterVMInstantCloneSpec vcenterVMInstantCloneSpec)



Create an instant clone of an existing virtual machine.  This operation was added in __vSphere API 6.7.1__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `VirtualMachine` referenced by the property *Vcenter.VM.InstantCloneSpec.source* requires `VirtualMachine.Provisioning.Clone` and `VirtualMachine.Inventory.CreateFromExisting`.    -  The resource `Folder` referenced by the property *Vcenter.VM.InstantClonePlacementSpec.folder* requires `VirtualMachine.Interact.PowerOn`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.InstantClonePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.    -  The resource `Datastore` referenced by the property *Vcenter.VM.InstantClonePlacementSpec.datastore* requires `Datastore.AllocateSpace`.    -  The resource `Network` referenced by the property *Vcenter.Vm.Hardware.Ethernet.BackingSpec.network* requires `Network.Assign`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMInstantCloneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vcenterVMInstantCloneSpec = new VcenterVMInstantCloneSpec(); // VcenterVMInstantCloneSpec | Virtual machine InstantCloneSpec.

            try
            {
                string result = apiInstance.VcenterVMInstantClone(vcenterVMInstantCloneSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMInstantClone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMInstantCloneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterVMInstantCloneWithHttpInfo(vcenterVMInstantCloneSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMInstantCloneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vcenterVMInstantCloneSpec** | [**VcenterVMInstantCloneSpec**](VcenterVMInstantCloneSpec.md) | Virtual machine InstantCloneSpec. |  |

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
| **400** | ***Vapi.Std.Errors.AlreadyExists*** if a virtual machine with the specified name already exists.  ***Vapi.Std.Errors.InvalidArgument*** if any of the specified parameters are invalid. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible.  ***Vapi.Std.Errors.UnableToAllocateResource*** if any of the resources needed to create an instant clone could not be allocated. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | ID of newly-created virtual machine.  The response will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmlist"></a>
# **VcenterVMList**
> List&lt;VcenterVMSummary&gt; VcenterVMList (List<string>? vms = null, List<string>? names = null, List<string>? folders = null, List<string>? datacenters = null, List<string>? hosts = null, List<string>? clusters = null, List<string>? resourcePools = null, List<string>? powerStates = null)



Returns information about at most 4000 visible (subject to permission checks) virtual machines in vCenter matching the *Vcenter.VM.FilterSpec*.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vms = new List<string>?(); // List<string>? | Identifiers of virtual machines that can match the filter.  If missing or `null` or empty, virtual machines with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `VirtualMachine`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `VirtualMachine`. (optional) 
            var names = new List<string>?(); // List<string>? | Names that virtual machines must have to match the filter (see *Vcenter.VM.Info.name*).  If missing or `null` or empty, virtual machines with any name match the filter. (optional) 
            var folders = new List<string>?(); // List<string>? | Folders that must contain the virtual machine for the virtual machine to match the filter.  If missing or `null` or empty, virtual machines in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Folder`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Folder`. (optional) 
            var datacenters = new List<string>?(); // List<string>? | Datacenters that must contain the virtual machine for the virtual machine to match the filter.  If missing or `null` or empty, virtual machines in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `Datacenter`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `Datacenter`. (optional) 
            var hosts = new List<string>?(); // List<string>? | Hosts that must contain the virtual machine for the virtual machine to match the filter.  If missing or `null` or empty, virtual machines on any host match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `HostSystem`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `HostSystem`. (optional) 
            var clusters = new List<string>?(); // List<string>? | Clusters that must contain the virtual machine for the virtual machine to match the filter.  If missing or `null` or empty, virtual machines in any cluster match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `ClusterComputeResource`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `ClusterComputeResource`. (optional) 
            var resourcePools = new List<string>?(); // List<string>? | Resource pools that must contain the virtual machine for the virtual machine to match the filter.  If missing or `null` or empty, virtual machines in any resource pool match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: `ResourcePool`. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: `ResourcePool`. (optional) 
            var powerStates = new List<string>?(); // List<string>? | Power states that a virtual machine must be in to match the filter (see *Vcenter.Vm.Power.Info.state*.  Possible values:   - `POWERED_OFF`: The virtual machine is powered off.   - `POWERED_ON`: The virtual machine is powered on.   - `SUSPENDED`: The virtual machine is suspended.   For more information see: *Vcenter.Vm.Power.State*.  If missing or `null` or empty, virtual machines in any power state match the filter. (optional) 

            try
            {
                List<VcenterVMSummary> result = apiInstance.VcenterVMList(vms, names, folders, datacenters, hosts, clusters, resourcePools, powerStates);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VcenterVMSummary>> response = apiInstance.VcenterVMListWithHttpInfo(vms, names, folders, datacenters, hosts, clusters, resourcePools, powerStates);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vms** | [**List&lt;string&gt;?**](string.md) | Identifiers of virtual machines that can match the filter.  If missing or &#x60;null&#x60; or empty, virtual machines with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;VirtualMachine&#x60;. | [optional]  |
| **names** | [**List&lt;string&gt;?**](string.md) | Names that virtual machines must have to match the filter (see *Vcenter.VM.Info.name*).  If missing or &#x60;null&#x60; or empty, virtual machines with any name match the filter. | [optional]  |
| **folders** | [**List&lt;string&gt;?**](string.md) | Folders that must contain the virtual machine for the virtual machine to match the filter.  If missing or &#x60;null&#x60; or empty, virtual machines in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Folder&#x60;. | [optional]  |
| **datacenters** | [**List&lt;string&gt;?**](string.md) | Datacenters that must contain the virtual machine for the virtual machine to match the filter.  If missing or &#x60;null&#x60; or empty, virtual machines in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datacenter&#x60;. | [optional]  |
| **hosts** | [**List&lt;string&gt;?**](string.md) | Hosts that must contain the virtual machine for the virtual machine to match the filter.  If missing or &#x60;null&#x60; or empty, virtual machines on any host match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional]  |
| **clusters** | [**List&lt;string&gt;?**](string.md) | Clusters that must contain the virtual machine for the virtual machine to match the filter.  If missing or &#x60;null&#x60; or empty, virtual machines in any cluster match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional]  |
| **resourcePools** | [**List&lt;string&gt;?**](string.md) | Resource pools that must contain the virtual machine for the virtual machine to match the filter.  If missing or &#x60;null&#x60; or empty, virtual machines in any resource pool match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ResourcePool&#x60;. | [optional]  |
| **powerStates** | [**List&lt;string&gt;?**](string.md) | Power states that a virtual machine must be in to match the filter (see *Vcenter.Vm.Power.Info.state*.  Possible values:   - &#x60;POWERED_OFF&#x60;: The virtual machine is powered off.   - &#x60;POWERED_ON&#x60;: The virtual machine is powered on.   - &#x60;SUSPENDED&#x60;: The virtual machine is suspended.   For more information see: *Vcenter.Vm.Power.State*.  If missing or &#x60;null&#x60; or empty, virtual machines in any power state match the filter. | [optional]  |

### Return type

[**List&lt;VcenterVMSummary&gt;**](VcenterVMSummary.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | if the *Vcenter.VM.FilterSpec.power_states* property contains a value that is not supported by the server. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **500** | if more than 4000 virtual machines match the *Vcenter.VM.FilterSpec*. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Commonly used information about the virtual machines matching the *Vcenter.VM.FilterSpec*. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmregister"></a>
# **VcenterVMRegister**
> string VcenterVMRegister (VcenterVMRegisterSpec vcenterVMRegisterSpec)



Creates a virtual machine from existing virtual machine files on storage.  This operation was added in __vSphere API 6.8.7__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `Datastore` referenced by the property *Vcenter.VM.RegisterSpec.datastore* requires `System.Read`.    -  The resource `Folder` referenced by the property *Vcenter.VM.InventoryPlacementSpec.folder* requires `VirtualMachine.Inventory.Register`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.ComputePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMRegisterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vcenterVMRegisterSpec = new VcenterVMRegisterSpec(); // VcenterVMRegisterSpec | Specification of the location of the virtual machine files and the placement of the new virtual machine.

            try
            {
                string result = apiInstance.VcenterVMRegister(vcenterVMRegisterSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMRegister: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMRegisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterVMRegisterWithHttpInfo(vcenterVMRegisterSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMRegisterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vcenterVMRegisterSpec** | [**VcenterVMRegisterSpec**](VcenterVMRegisterSpec.md) | Specification of the location of the virtual machine files and the placement of the new virtual machine. |  |

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
| **400** | ***Vapi.Std.Errors.AlreadyExists*** if a virtual machine with the specified name already exists or if a virtual machine using the specified virtual machine files already exists.  ***Vapi.Std.Errors.InvalidArgument*** if any of the specified parameters are invalid. |  -  |
| **401** | if the user cannot be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec could not be found. |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible.  ***Vapi.Std.Errors.UnableToAllocateResource*** if any of the resources needed to register the virtual machine could not be allocated. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **200** | Identifier of the newly-created virtual machine.  The response will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmrelocate"></a>
# **VcenterVMRelocate**
> void VcenterVMRelocate (string vm, VcenterVMRelocateSpec vcenterVMRelocateSpec)



Relocates a virtual machine based on the specification. The parts of the virtual machine that can move are: FOLDER, RESOURCE_POOL, HOST, CLUSTER and DATASTORE of home of the virtual machine and disks.     This operation was added in __vSphere API 7.0.0.0__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `VirtualMachine` referenced by the parameter vm requires `Resource.ColdMigrate`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.RelocatePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMRelocateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vm = "vm_example";  // string | Existing Virtual machine to relocate.  The parameter must be an identifier for the resource type: `VirtualMachine`.
            var vcenterVMRelocateSpec = new VcenterVMRelocateSpec(); // VcenterVMRelocateSpec | Relocate specification.

            try
            {
                apiInstance.VcenterVMRelocate(vm, vcenterVMRelocateSpec);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMRelocate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMRelocateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VcenterVMRelocateWithHttpInfo(vm, vcenterVMRelocateSpec);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMRelocateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vm** | **string** | Existing Virtual machine to relocate.  The parameter must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  |
| **vcenterVMRelocateSpec** | [**VcenterVMRelocateSpec**](VcenterVMRelocateSpec.md) | Relocate specification. |  |

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
| **400** | if any of the specified parameters are invalid. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec or the given \&quot;vm\&quot; could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **204** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmrelocatetask"></a>
# **VcenterVMRelocateTask**
> string VcenterVMRelocateTask (string vm, VcenterVMRelocateSpec vcenterVMRelocateSpec)



Relocates a virtual machine based on the specification. The parts of the virtual machine that can move are: FOLDER, RESOURCE_POOL, HOST, CLUSTER and DATASTORE of home of the virtual machine and disks.     This operation was added in __vSphere API 7.0.0.0__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `VirtualMachine` referenced by the parameter vm requires `Resource.ColdMigrate`.    -  The resource `ResourcePool` referenced by the property *Vcenter.VM.RelocatePlacementSpec.resource_pool* requires `Resource.AssignVMToPool`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMRelocateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vm = "vm_example";  // string | Existing Virtual machine to relocate.  The parameter must be an identifier for the resource type: `VirtualMachine`.
            var vcenterVMRelocateSpec = new VcenterVMRelocateSpec(); // VcenterVMRelocateSpec | Relocate specification.

            try
            {
                string result = apiInstance.VcenterVMRelocateTask(vm, vcenterVMRelocateSpec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMRelocateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMRelocateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.VcenterVMRelocateTaskWithHttpInfo(vm, vcenterVMRelocateSpec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMRelocateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vm** | **string** | Existing Virtual machine to relocate.  The parameter must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  |
| **vcenterVMRelocateSpec** | [**VcenterVMRelocateSpec**](VcenterVMRelocateSpec.md) | Relocate specification. |  |

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
| **400** | if any of the specified parameters are invalid. |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **404** | if any of the resources specified in spec or the given \&quot;vm\&quot; could not be found |  -  |
| **500** | ***Vapi.Std.Errors.Error*** if the system reports an error while responding to the request.  ***Vapi.Std.Errors.ResourceInaccessible*** if a specified resource (eg. host) is not accessible. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **202** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vcentervmunregister"></a>
# **VcenterVMUnregister**
> void VcenterVMUnregister (string vm)



Removes the virtual machine corresponding to vm from the vCenter inventory without removing any of the virtual machine's files from storage. All high-level information stored with the management server (ESXi or vCenter) is removed, including information such as statistics, resource pool association, permissions, and alarms.  This operation was added in __vSphere API 6.8.7__.  Returns an authorization error if you do not have all of the privileges described as follows:     -  The resource `VirtualMachine` referenced by the parameter vm requires `VirtualMachine.Inventory.Unregister`.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class VcenterVMUnregisterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new VcenterVMApi(config);
            var vm = "vm_example";  // string | Identifier of the virtual machine to be unregistered.  The parameter must be an identifier for the resource type: `VirtualMachine`.

            try
            {
                apiInstance.VcenterVMUnregister(vm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VcenterVMApi.VcenterVMUnregister: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VcenterVMUnregisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VcenterVMUnregisterWithHttpInfo(vm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VcenterVMApi.VcenterVMUnregisterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vm** | **string** | Identifier of the virtual machine to be unregistered.  The parameter must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. |  |

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
| **400** | if the virtual machine is running (powered on). |  -  |
| **401** | if the user can not be authenticated. |  -  |
| **403** | if the user doesn&#39;t have the required privileges. |  -  |
| **500** | if the virtual machine is busy performing another operation. |  -  |
| **404** | if there is no virtual machine associated with vm in the system. |  -  |
| **503** | if the system is unable to communicate with a service to complete the request. |  -  |
| **204** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

