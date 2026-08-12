# Vcenter.ViJson.OpenApi.Api.FolderApi

All URIs are relative to *https://localhost/sdk/vim25/9.1.0.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FolderAddStandaloneHostTask**](FolderApi.md#folderaddstandalonehosttask) | **POST** /Folder/{moId}/AddStandaloneHost_Task | Creates a new single-host compute resource.  |
| [**FolderBatchAddHostsToClusterTask**](FolderApi.md#folderbatchaddhoststoclustertask) | **POST** /Folder/{moId}/BatchAddHostsToCluster_Task | Adds a set of new and existing hosts to the cluster.  |
| [**FolderBatchAddStandaloneHostsTask**](FolderApi.md#folderbatchaddstandalonehoststask) | **POST** /Folder/{moId}/BatchAddStandaloneHosts_Task | Adds a list of hosts to inventory, as standalone hosts, in a single invocation.  |
| [**FolderCreateCluster**](FolderApi.md#foldercreatecluster) | **POST** /Folder/{moId}/CreateCluster | Creates a new cluster compute resource in this folder.  |
| [**FolderCreateClusterEx**](FolderApi.md#foldercreateclusterex) | **POST** /Folder/{moId}/CreateClusterEx | Creates a new cluster compute resource in this folder.  |
| [**FolderCreateDVSTask**](FolderApi.md#foldercreatedvstask) | **POST** /Folder/{moId}/CreateDVS_Task | Create a *DistributedVirtualSwitch* in the folder according to the specified *DVSCreateSpec*.  |
| [**FolderCreateDatacenter**](FolderApi.md#foldercreatedatacenter) | **POST** /Folder/{moId}/CreateDatacenter | Creates a new datacenter with the given name.  |
| [**FolderCreateFolder**](FolderApi.md#foldercreatefolder) | **POST** /Folder/{moId}/CreateFolder | Creates a new sub-folder with the specified name.  |
| [**FolderCreateStoragePod**](FolderApi.md#foldercreatestoragepod) | **POST** /Folder/{moId}/CreateStoragePod | Creates a new storage pod in this folder.  |
| [**FolderCreateVMTask**](FolderApi.md#foldercreatevmtask) | **POST** /Folder/{moId}/CreateVM_Task | Creates a new virtual machine in the current folder and attaches it to the specified resource pool.  |
| [**FolderDestroyTask**](FolderApi.md#folderdestroytask) | **POST** /Folder/{moId}/Destroy_Task | Destroys this object, deleting its contents and removing it from its parent folder (if any).  |
| [**FolderGetAlarmActionsEnabled**](FolderApi.md#foldergetalarmactionsenabled) | **GET** /Folder/{moId}/alarmActionsEnabled | Whether alarm actions are enabled for this entity.  |
| [**FolderGetAvailableField**](FolderApi.md#foldergetavailablefield) | **GET** /Folder/{moId}/availableField | List of custom field definitions that are valid for the object&#39;s type.  |
| [**FolderGetChildEntity**](FolderApi.md#foldergetchildentity) | **GET** /Folder/{moId}/childEntity | An array of managed object references.  |
| [**FolderGetChildType**](FolderApi.md#foldergetchildtype) | **GET** /Folder/{moId}/childType | Specifies the object types a folder may contain.  |
| [**FolderGetConfigIssue**](FolderApi.md#foldergetconfigissue) | **GET** /Folder/{moId}/configIssue | Current configuration issues that have been detected for this entity.  |
| [**FolderGetConfigStatus**](FolderApi.md#foldergetconfigstatus) | **GET** /Folder/{moId}/configStatus | The configStatus indicates whether or not the system has detected a configuration issue involving this entity.  |
| [**FolderGetCustomValue**](FolderApi.md#foldergetcustomvalue) | **GET** /Folder/{moId}/customValue | Custom field values.  |
| [**FolderGetDeclaredAlarmState**](FolderApi.md#foldergetdeclaredalarmstate) | **GET** /Folder/{moId}/declaredAlarmState | A set of alarm states for alarms that apply to this managed entity.  |
| [**FolderGetDisabledMethod**](FolderApi.md#foldergetdisabledmethod) | **GET** /Folder/{moId}/disabledMethod | List of operations that are disabled, given the current runtime state of the entity.  |
| [**FolderGetEffectiveRole**](FolderApi.md#foldergeteffectiverole) | **GET** /Folder/{moId}/effectiveRole | Access rights the current session has to this entity.  |
| [**FolderGetExternallyManagedFolderInfo**](FolderApi.md#foldergetexternallymanagedfolderinfo) | **GET** /Folder/{moId}/externallyManagedFolderInfo | The information of externally managed folder.  |
| [**FolderGetName**](FolderApi.md#foldergetname) | **GET** /Folder/{moId}/name | Name of this entity, unique relative to its parent.  |
| [**FolderGetNamespace**](FolderApi.md#foldergetnamespace) | **GET** /Folder/{moId}/namespace | The namespace with which the Folder is associated.  |
| [**FolderGetOverallStatus**](FolderApi.md#foldergetoverallstatus) | **GET** /Folder/{moId}/overallStatus | General health of this managed entity.  |
| [**FolderGetParent**](FolderApi.md#foldergetparent) | **GET** /Folder/{moId}/parent | Parent of this entity.  |
| [**FolderGetPermission**](FolderApi.md#foldergetpermission) | **GET** /Folder/{moId}/permission | List of the permissions explicitly defined for this entity.  |
| [**FolderGetRecentTask**](FolderApi.md#foldergetrecenttask) | **GET** /Folder/{moId}/recentTask | The set of recent tasks operating on this managed entity.  |
| [**FolderGetTag**](FolderApi.md#foldergettag) | **GET** /Folder/{moId}/tag | The set of tags associated with this managed entity.  |
| [**FolderGetTriggeredAlarmState**](FolderApi.md#foldergettriggeredalarmstate) | **GET** /Folder/{moId}/triggeredAlarmState | A set of alarm states for alarms triggered by this entity or by its descendants.  |
| [**FolderGetValue**](FolderApi.md#foldergetvalue) | **GET** /Folder/{moId}/value | List of custom field values.  |
| [**FolderMoveIntoFolderTask**](FolderApi.md#foldermoveintofoldertask) | **POST** /Folder/{moId}/MoveIntoFolder_Task | Moves a set of managed entities into this folder.  |
| [**FolderRegisterVMTask**](FolderApi.md#folderregistervmtask) | **POST** /Folder/{moId}/RegisterVM_Task | Adds an existing virtual machine to the folder.  |
| [**FolderReload**](FolderApi.md#folderreload) | **POST** /Folder/{moId}/Reload | Reload the entity state.  |
| [**FolderRenameTask**](FolderApi.md#folderrenametask) | **POST** /Folder/{moId}/Rename_Task | Renames this managed entity.  |
| [**FolderSetCustomValue**](FolderApi.md#foldersetcustomvalue) | **POST** /Folder/{moId}/setCustomValue | Assigns a value to a custom field.  |
| [**FolderUnregisterAndDestroyTask**](FolderApi.md#folderunregisteranddestroytask) | **POST** /Folder/{moId}/UnregisterAndDestroy_Task | Recursively unregisters all virtual machines and vApps, and destroys all child virtual machine folders.  |

<a id="folderaddstandalonehosttask"></a>
# **FolderAddStandaloneHostTask**
> ManagedObjectReference FolderAddStandaloneHostTask (string moId, AddStandaloneHostRequestType addStandaloneHostRequestType)

Creates a new single-host compute resource. 

Creates a new single-host compute resource.  The name provided can be an IP address, such as 192.168.0.120, or a string, such as esx120. If a name is specified, a DNS lookup is used to resolve it to a fully-qualified name, such as esx120.vmware.com. If the DNS lookup fails, the string is stored as specified.  Licenses for the host are allocated when making the first connection to the host. This is because the license needed typically depends on the type of host and the number of CPUs.  In addition to the Host.Inventory.AddStandaloneHost privilege, it requires System.View privilege on the VM folder that the VMs of the host will be placed on.  ***Required privileges:*** Host.Inventory.AddStandaloneHost 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderAddStandaloneHostTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var addStandaloneHostRequestType = new AddStandaloneHostRequestType(); // AddStandaloneHostRequestType | 

            try
            {
                // Creates a new single-host compute resource. 
                ManagedObjectReference result = apiInstance.FolderAddStandaloneHostTask(moId, addStandaloneHostRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderAddStandaloneHostTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderAddStandaloneHostTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new single-host compute resource. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderAddStandaloneHostTaskWithHttpInfo(moId, addStandaloneHostRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderAddStandaloneHostTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **addStandaloneHostRequestType** | [**AddStandaloneHostRequestType**](AddStandaloneHostRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly added *ComputeResource* upon success.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidLogin***: if authentication with the host fails.  ***InvalidArgument***: if an argument is specified incorrectly.  ***AlreadyBeingManaged***: if the host is already being managed by a vCenter server. If the host is being managed by a different vCenter server, this can be overridden by the \&quot;force\&quot; flag in the connection specification.  ***NotEnoughLicenses***: if there are not enough licenses to add the host.  ***NoHost***: if the host cannot be contacted.  ***NotSupported***: if the host is being added to a folder whose *Folder.childType* property does not contain \&quot;ComputeResource\&quot;.  ***NotSupportedHost***: if the host is running a software version that is not supported.  ***AgentInstallFailed***: if there is an error installing the vCenter agent on the new host.  ***AlreadyConnected***: if addConnected is true and the host is already connected to vCenter.  ***HostConnectFault***: if an error occurred when attempting to connect to a host. Typically, a more specific subclass, such as AlreadyBeingManaged, is thrown.  ***SSLVerifyFault***: if the host certificate could not be authenticated  ***DuplicateName***: if another host in the same folder has the name.  ***NoPermission***: if there are crypto keys to be sent to the host, but the user does not have Cryptographer.RegisterHost privilege on the Folder.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderbatchaddhoststoclustertask"></a>
# **FolderBatchAddHostsToClusterTask**
> ManagedObjectReference FolderBatchAddHostsToClusterTask (string moId, BatchAddHostsToClusterRequestType batchAddHostsToClusterRequestType)

Adds a set of new and existing hosts to the cluster. 

Adds a set of new and existing hosts to the cluster.  This API is a composite API and performs the following tasks before hosts become part of the specified cluster - - Adds all new hosts as standalone hosts. - Move each host to the desired state. - Move each host to the cluster.    The dynamic privilege check will ensure that appropriate privileges are acquired to allow this API to perform multiple actions on hosts and cluster. Required privileges - - Host.Inventory.EditCluster on cluster - Host.Config.Maintenance on the hosts if desiredState is set - Privileges for *Folder.BatchAddStandaloneHosts_Task* if newHosts is   set - Host.Inventory.EditCluster on the hosts' source ComputeResource - Host.Inventory.MoveHost on the hosts 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderBatchAddHostsToClusterTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var batchAddHostsToClusterRequestType = new BatchAddHostsToClusterRequestType(); // BatchAddHostsToClusterRequestType | 

            try
            {
                // Adds a set of new and existing hosts to the cluster. 
                ManagedObjectReference result = apiInstance.FolderBatchAddHostsToClusterTask(moId, batchAddHostsToClusterRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderBatchAddHostsToClusterTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderBatchAddHostsToClusterTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a set of new and existing hosts to the cluster. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderBatchAddHostsToClusterTaskWithHttpInfo(moId, batchAddHostsToClusterRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderBatchAddHostsToClusterTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **batchAddHostsToClusterRequestType** | [**BatchAddHostsToClusterRequestType**](BatchAddHostsToClusterRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderbatchaddstandalonehoststask"></a>
# **FolderBatchAddStandaloneHostsTask**
> ManagedObjectReference FolderBatchAddStandaloneHostsTask (string moId, BatchAddStandaloneHostsRequestType batchAddStandaloneHostsRequestType)

Adds a list of hosts to inventory, as standalone hosts, in a single invocation. 

Adds a list of hosts to inventory, as standalone hosts, in a single invocation.  The operation returns a result containing a list of hosts that are successfully added.  In addition to the Host.Inventory.AddStandaloneHost privilege, the operation requires System.View privilege on the VM folder that the VMs of the host will be placed on.  ***Required privileges:*** Host.Inventory.AddStandaloneHost 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderBatchAddStandaloneHostsTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var batchAddStandaloneHostsRequestType = new BatchAddStandaloneHostsRequestType(); // BatchAddStandaloneHostsRequestType | 

            try
            {
                // Adds a list of hosts to inventory, as standalone hosts, in a single invocation. 
                ManagedObjectReference result = apiInstance.FolderBatchAddStandaloneHostsTask(moId, batchAddStandaloneHostsRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderBatchAddStandaloneHostsTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderBatchAddStandaloneHostsTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a list of hosts to inventory, as standalone hosts, in a single invocation. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderBatchAddStandaloneHostsTaskWithHttpInfo(moId, batchAddStandaloneHostsRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderBatchAddStandaloneHostsTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **batchAddStandaloneHostsRequestType** | [**BatchAddStandaloneHostsRequestType**](BatchAddStandaloneHostsRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreatecluster"></a>
# **FolderCreateCluster**
> ManagedObjectReference FolderCreateCluster (string moId, CreateClusterRequestType createClusterRequestType)

Creates a new cluster compute resource in this folder. 

Deprecated as of VI API 2.5, use *Folder.CreateClusterEx*.  Creates a new cluster compute resource in this folder.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  ***Required privileges:*** Host.Inventory.CreateCluster 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateClusterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createClusterRequestType = new CreateClusterRequestType(); // CreateClusterRequestType | 

            try
            {
                // Creates a new cluster compute resource in this folder. 
                ManagedObjectReference result = apiInstance.FolderCreateCluster(moId, createClusterRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateCluster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateClusterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new cluster compute resource in this folder. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateClusterWithHttpInfo(moId, createClusterRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateClusterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createClusterRequestType** | [**CreateClusterRequestType**](CreateClusterRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A new ClusterComputeResource instance.  Refers instance of *ClusterComputeResource*.  |  -  |
| **500** | ***DuplicateName***: if an entity with that name already exists.  ***InvalidArgument***: if the cluster configuration specification parameter is invalid.  ***InvalidName***: if the name is not a valid entity name.  ***NotSupported***: if the cluster is being added to a folder whose *Folder.childType* property value does not contain \&quot;ComputeResource\&quot; or \&quot;ClusterComputeResource\&quot;.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreateclusterex"></a>
# **FolderCreateClusterEx**
> ManagedObjectReference FolderCreateClusterEx (string moId, CreateClusterExRequestType createClusterExRequestType)

Creates a new cluster compute resource in this folder. 

Creates a new cluster compute resource in this folder.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  ***Required privileges:*** Host.Inventory.CreateCluster 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateClusterExExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createClusterExRequestType = new CreateClusterExRequestType(); // CreateClusterExRequestType | 

            try
            {
                // Creates a new cluster compute resource in this folder. 
                ManagedObjectReference result = apiInstance.FolderCreateClusterEx(moId, createClusterExRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateClusterEx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateClusterExWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new cluster compute resource in this folder. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateClusterExWithHttpInfo(moId, createClusterExRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateClusterExWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createClusterExRequestType** | [**CreateClusterExRequestType**](CreateClusterExRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A new ClusterComputeResource instance.  Refers instance of *ClusterComputeResource*.  |  -  |
| **500** | ***DuplicateName***: if an entity with that name already exists.  ***InvalidArgument***: if the cluster configuration specification parameter is invalid.  ***InvalidName***: if the name is not a valid entity name.  ***NotSupported***: if the cluster is being added to a folder whose *Folder.childType* property value does not contain \&quot;ComputeResource\&quot; or \&quot;ClusterComputeResource\&quot;.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreatedvstask"></a>
# **FolderCreateDVSTask**
> ManagedObjectReference FolderCreateDVSTask (string moId, CreateDVSRequestType createDVSRequestType)

Create a *DistributedVirtualSwitch* in the folder according to the specified *DVSCreateSpec*. 

Create a *DistributedVirtualSwitch* in the folder according to the specified *DVSCreateSpec*.  The specified Folder must be a Network entity folder.  ***Required privileges:*** DVSwitch.Create 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateDVSTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createDVSRequestType = new CreateDVSRequestType(); // CreateDVSRequestType | 

            try
            {
                // Create a *DistributedVirtualSwitch* in the folder according to the specified *DVSCreateSpec*. 
                ManagedObjectReference result = apiInstance.FolderCreateDVSTask(moId, createDVSRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateDVSTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateDVSTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a *DistributedVirtualSwitch* in the folder according to the specified *DVSCreateSpec*. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateDVSTaskWithHttpInfo(moId, createDVSRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateDVSTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createDVSRequestType** | [**CreateDVSRequestType**](CreateDVSRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. After successful completion, the *Task*.*Task.info*.*TaskInfo.result* property contains the newly registered *DistributedVirtualSwitch*.  Refers instance of *Task*.  |  -  |
| **500** | ***NotSupported***: if called directly on a host.  ***DvsNotAuthorized***: if login-session&#39;s extension key does not match (*DVSConfigInfo.extensionKey*).  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreatedatacenter"></a>
# **FolderCreateDatacenter**
> ManagedObjectReference FolderCreateDatacenter (string moId, CreateDatacenterRequestType createDatacenterRequestType)

Creates a new datacenter with the given name. 

Creates a new datacenter with the given name.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  ***Required privileges:*** Datacenter.Create 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateDatacenterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createDatacenterRequestType = new CreateDatacenterRequestType(); // CreateDatacenterRequestType | 

            try
            {
                // Creates a new datacenter with the given name. 
                ManagedObjectReference result = apiInstance.FolderCreateDatacenter(moId, createDatacenterRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateDatacenter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateDatacenterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new datacenter with the given name. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateDatacenterWithHttpInfo(moId, createDatacenterRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateDatacenterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createDatacenterRequestType** | [**CreateDatacenterRequestType**](CreateDatacenterRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A new Datacenter instance.  Refers instance of *Datacenter*.  |  -  |
| **500** | ***DuplicateName***: if an entity with that name already exists.  ***InvalidName***: if the new name is not a valid entity name.  ***NotSupported***: if the datacenter is being created within a folder whose *Folder.childType* property value does not contain \&quot;Datacenter\&quot;.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreatefolder"></a>
# **FolderCreateFolder**
> ManagedObjectReference FolderCreateFolder (string moId, CreateFolderRequestType createFolderRequestType)

Creates a new sub-folder with the specified name. 

Creates a new sub-folder with the specified name.  The *Folder.childType* property of the new folder is the same as the *Folder.childType* property of the current folder.  ***Required privileges:*** Folder.Create 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createFolderRequestType = new CreateFolderRequestType(); // CreateFolderRequestType | 

            try
            {
                // Creates a new sub-folder with the specified name. 
                ManagedObjectReference result = apiInstance.FolderCreateFolder(moId, createFolderRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new sub-folder with the specified name. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateFolderWithHttpInfo(moId, createFolderRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createFolderRequestType** | [**CreateFolderRequestType**](CreateFolderRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A reference to the new folder.  Refers instance of *Folder*.  |  -  |
| **500** | ***DuplicateName***: if another object in the same folder has the target name.  ***InvalidName***: if the name is not a valid entity name.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreatestoragepod"></a>
# **FolderCreateStoragePod**
> ManagedObjectReference FolderCreateStoragePod (string moId, CreateStoragePodRequestType createStoragePodRequestType)

Creates a new storage pod in this folder. 

Creates a new storage pod in this folder.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  ***Required privileges:*** Folder.Create 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateStoragePodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createStoragePodRequestType = new CreateStoragePodRequestType(); // CreateStoragePodRequestType | 

            try
            {
                // Creates a new storage pod in this folder. 
                ManagedObjectReference result = apiInstance.FolderCreateStoragePod(moId, createStoragePodRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateStoragePod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateStoragePodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new storage pod in this folder. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateStoragePodWithHttpInfo(moId, createStoragePodRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateStoragePodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createStoragePodRequestType** | [**CreateStoragePodRequestType**](CreateStoragePodRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A new StoragePod instance.  Refers instance of *StoragePod*.  |  -  |
| **500** | ***DuplicateName***: if an entity with that name already exists.  ***InvalidName***: if the name is not a valid entity name.  ***NotSupported***: if the storage pod is being added to a folder whose *Folder.childType* property value does not contain \&quot;StoragePod\&quot;.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldercreatevmtask"></a>
# **FolderCreateVMTask**
> ManagedObjectReference FolderCreateVMTask (string moId, CreateVMRequestType createVMRequestType)

Creates a new virtual machine in the current folder and attaches it to the specified resource pool. 

Creates a new virtual machine in the current folder and attaches it to the specified resource pool.  This operation creates a virtual machine, instead of cloning a virtual machine from an existing one.  The server does not support creating templates using this method. Instead, you should create templates by marking existing virtual machines as templates, or by cloning an existing virtual machine or template.  This operation only works if the folder's childType includes VirtualMachine. In addition to the VirtualMachine.Inventory.Create privilege, may also require any of the following privileges depending on the properties of the virtual machine bring created: - VirtualMachine.Config.AddExistingDisk if including a virtual disk device   that refers to an existing virtual disk file (not RDM) - VirtualMachine.Config.AddNewDisk if including a virtual disk device that   creates a new virtual disk file (not RDM) - VirtualMachine.Config.RawDevice if including a raw device mapping   (RDM) or SCSI passthrough device - VirtualMachine.Config.HostUSBDevice if including a VirtualUSB device   backed by a host USB device - VirtualMachine.Config.AdvancedConfig if setting values in   ConfigSpec.extraConfig - VirtualMachine.Config.SwapPlacement if setting swapPlacement - VirtualMachine.Config.ChangeTracking if setting changed   block tracking for the virtual machine's disks. - Datastore.AllocateSpace required on all datastores where the   virtual machine and its virtual disks will be created - Network.Assign required on the network which is assigned to the   new virtual machine that is being created - Cryptographer.EncryptNew on the folder if the created virtual   machine is encrypted - Cryptographer.RegisterHost on the host if the created virtual   machine is encrypted, but encryption is not enabled on the host    To create a VirtualDisk on a persistent memory storage, the storage must be specified via *profile* while the datastore property of corresponding VirtualDisk backing must be unset.  To create a VirtualNVDIMM device, the storage *profile* must be set to the default persistent memory storage profile while the datastore property of *the device backing* must be unset.  ***Required privileges:*** VirtualMachine.Inventory.Create 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderCreateVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var createVMRequestType = new CreateVMRequestType(); // CreateVMRequestType | 

            try
            {
                // Creates a new virtual machine in the current folder and attaches it to the specified resource pool. 
                ManagedObjectReference result = apiInstance.FolderCreateVMTask(moId, createVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderCreateVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderCreateVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new virtual machine in the current folder and attaches it to the specified resource pool. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderCreateVMTaskWithHttpInfo(moId, createVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderCreateVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **createVMRequestType** | [**CreateVMRequestType**](CreateVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly created *VirtualMachine* upon success.  Refers instance of *Task*.  |  -  |
| **500** | ***VmConfigFault***: if the configSpec has incorrect values. Typically, a more specific subclass is thrown.  ***OutOfBounds***: if Host.capability.maxSupportedVMs is exceeded.  ***FileAlreadyExists***: if the requested cfgPath for the virtual machine&#39;s configuration file already exists.  ***FileFault***: if there is a problem creating the virtual machine on disk. Typically, a more specific subclass, such as NoDiskSpace, will be thrown.  ***DuplicateName***: if another virtual machine in the same folder already has the specified target name.  ***InvalidName***: if the name is not a valid entity name.  ***NotSupported***: if the virtual machine is being created within a folder whose *Folder.childType* property is not set to \&quot;VirtualMachine\&quot;.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***InvalidDatastore***: if the operation cannot be performed on the target datastores.  ***VmWwnConflict***: if the WWN of the virtual machine has been used by other virtual machines.  ***AlreadyExists***: if the requested cfgPath (or the default cfgPath) for the virtual machine&#39;s configuration file is already loaded in the inventory.  ***InvalidState***: if the operation is not allowed in current state of the entities involved.  ***NoPermission***: if the created virtual machine is encrypted but the user does not have Cryptographer.EncryptNew on the folder.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderdestroytask"></a>
# **FolderDestroyTask**
> ManagedObjectReference FolderDestroyTask (string moId)

Destroys this object, deleting its contents and removing it from its parent folder (if any). 

Destroys this object, deleting its contents and removing it from its parent folder (if any).  NOTE: The appropriate privilege must be held on the parent of the destroyed entity as well as the entity itself. This method can throw one of several exceptions. The exact set of exceptions depends on the kind of entity that is being removed. See comments for each entity for more information on destroy behavior.  ***Required privileges:*** Folder.Delete 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderDestroyTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Destroys this object, deleting its contents and removing it from its parent folder (if any). 
                ManagedObjectReference result = apiInstance.FolderDestroyTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderDestroyTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderDestroyTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Destroys this object, deleting its contents and removing it from its parent folder (if any). 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderDestroyTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderDestroyTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | Failure  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetalarmactionsenabled"></a>
# **FolderGetAlarmActionsEnabled**
> bool? FolderGetAlarmActionsEnabled (string moId)

Whether alarm actions are enabled for this entity. 

Whether alarm actions are enabled for this entity.  True if enabled; false otherwise.  ***Required privileges:*** System.Read 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetAlarmActionsEnabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Whether alarm actions are enabled for this entity. 
                bool? result = apiInstance.FolderGetAlarmActionsEnabled(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetAlarmActionsEnabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetAlarmActionsEnabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Whether alarm actions are enabled for this entity. 
    ApiResponse<bool?> response = apiInstance.FolderGetAlarmActionsEnabledWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetAlarmActionsEnabledWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**bool?**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetavailablefield"></a>
# **FolderGetAvailableField**
> List&lt;CustomFieldDef&gt; FolderGetAvailableField (string moId)

List of custom field definitions that are valid for the object's type. 

List of custom field definitions that are valid for the object's type.  The fields are sorted by *CustomFieldDef.name*.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetAvailableFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of custom field definitions that are valid for the object's type. 
                List<CustomFieldDef> result = apiInstance.FolderGetAvailableField(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetAvailableField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetAvailableFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of custom field definitions that are valid for the object's type. 
    ApiResponse<List<CustomFieldDef>> response = apiInstance.FolderGetAvailableFieldWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetAvailableFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;CustomFieldDef&gt;**](CustomFieldDef.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetchildentity"></a>
# **FolderGetChildEntity**
> List&lt;ManagedObjectReference&gt; FolderGetChildEntity (string moId)

An array of managed object references. 

An array of managed object references.  Each entry is a reference to a child entity.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetChildEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // An array of managed object references. 
                List<ManagedObjectReference> result = apiInstance.FolderGetChildEntity(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetChildEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetChildEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // An array of managed object references. 
    ApiResponse<List<ManagedObjectReference>> response = apiInstance.FolderGetChildEntityWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetChildEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instances of *ManagedEntity*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetchildtype"></a>
# **FolderGetChildType**
> List&lt;string&gt; FolderGetChildType (string moId)

Specifies the object types a folder may contain. 

Specifies the object types a folder may contain.  When you create a folder, it inherits its childType from the parent folder in which it is created. childType is an array of strings. Each array entry identifies a set of object types - Folder and one or more managed object types. The following list shows childType values for the different folders: - { \"vim.Folder\", \"vim.Datacenter\" } - Identifies the root folder   and its descendant folders. Data center folders can contain   child data center folders and Datacenter managed objects.   Datacenter objects contain virtual machine, compute resource,   network entity, and datastore folders. - { \"vim.Folder\", \"vim.Virtualmachine\", \"vim.VirtualApp\" } - Identifies   a virtual machine folder. A virtual machine folder may contain child   virtual machine folders. It also can contain VirtualMachine managed objects,   templates, and VirtualApp managed objects. - { \"vim.Folder\", \"vim.ComputeResource\" } - Identifies a   compute resource folder, which contains child compute resource folders   and ComputeResource hierarchies. - { \"vim.Folder\", \"vim.Network\" } - Identifies a network entity folder.   Network entity folders on a vCenter Server can contain Network,   DistributedVirtualSwitch, and DistributedVirtualPortgroup managed   objects. Network entity folders on an ESXi host can contain only   Network objects. - { \"vim.Folder\", \"vim.Datastore\" } - Identifies a datastore folder.   Datastore folders can contain child datastore folders and Datastore   managed objects.    ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetChildTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Specifies the object types a folder may contain. 
                List<string> result = apiInstance.FolderGetChildType(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetChildType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetChildTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Specifies the object types a folder may contain. 
    ApiResponse<List<string>> response = apiInstance.FolderGetChildTypeWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetChildTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<string>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetconfigissue"></a>
# **FolderGetConfigIssue**
> List&lt;Event&gt; FolderGetConfigIssue (string moId)

Current configuration issues that have been detected for this entity. 

Current configuration issues that have been detected for this entity.  Typically, these issues have already been logged as events. The entity stores these events as long as they are still current. The *configStatus* property provides an overall status based on these events. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetConfigIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Current configuration issues that have been detected for this entity. 
                List<Event> result = apiInstance.FolderGetConfigIssue(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetConfigIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetConfigIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Current configuration issues that have been detected for this entity. 
    ApiResponse<List<Event>> response = apiInstance.FolderGetConfigIssueWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetConfigIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;Event&gt;**](Event.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetconfigstatus"></a>
# **FolderGetConfigStatus**
> ManagedEntityStatusEnum FolderGetConfigStatus (string moId)

The configStatus indicates whether or not the system has detected a configuration issue involving this entity. 

The configStatus indicates whether or not the system has detected a configuration issue involving this entity.  For example, it might have detected a duplicate IP address or MAC address, or a host in a cluster might be out of compliance. The meanings of the configStatus values are: - red: A problem has been detected involving the entity. - yellow: A problem is about to occur or a transient condition   has occurred (For example, reconfigure fail-over policy). - green: No configuration issues have been detected. - gray: The configuration status of the entity is not being monitored.    A green status indicates only that a problem has not been detected; it is not a guarantee that the entity is problem-free.  The *configIssue* property contains a list of the problems that have been detected. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetConfigStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The configStatus indicates whether or not the system has detected a configuration issue involving this entity. 
                ManagedEntityStatusEnum result = apiInstance.FolderGetConfigStatus(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetConfigStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetConfigStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The configStatus indicates whether or not the system has detected a configuration issue involving this entity. 
    ApiResponse<ManagedEntityStatusEnum> response = apiInstance.FolderGetConfigStatusWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetConfigStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedEntityStatusEnum**](ManagedEntityStatusEnum.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetcustomvalue"></a>
# **FolderGetCustomValue**
> List&lt;CustomFieldValue&gt; FolderGetCustomValue (string moId)

Custom field values. 

Custom field values.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetCustomValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Custom field values. 
                List<CustomFieldValue> result = apiInstance.FolderGetCustomValue(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetCustomValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetCustomValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Custom field values. 
    ApiResponse<List<CustomFieldValue>> response = apiInstance.FolderGetCustomValueWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetCustomValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;CustomFieldValue&gt;**](CustomFieldValue.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetdeclaredalarmstate"></a>
# **FolderGetDeclaredAlarmState**
> List&lt;AlarmState&gt; FolderGetDeclaredAlarmState (string moId)

A set of alarm states for alarms that apply to this managed entity. 

A set of alarm states for alarms that apply to this managed entity.  The set includes alarms defined on this entity and alarms inherited from the parent entity, or from any ancestors in the inventory hierarchy.  Alarms are inherited if they can be triggered by this entity or its descendants. This set does not include alarms that are defined on descendants of this entity.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetDeclaredAlarmStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // A set of alarm states for alarms that apply to this managed entity. 
                List<AlarmState> result = apiInstance.FolderGetDeclaredAlarmState(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetDeclaredAlarmState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetDeclaredAlarmStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A set of alarm states for alarms that apply to this managed entity. 
    ApiResponse<List<AlarmState>> response = apiInstance.FolderGetDeclaredAlarmStateWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetDeclaredAlarmStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;AlarmState&gt;**](AlarmState.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetdisabledmethod"></a>
# **FolderGetDisabledMethod**
> List&lt;string&gt; FolderGetDisabledMethod (string moId)

List of operations that are disabled, given the current runtime state of the entity. 

List of operations that are disabled, given the current runtime state of the entity.  For example, a power-on operation always fails if a virtual machine is already powered on. This list can be used by clients to enable or disable operations in a graphical user interface.  Note: This list is determined by the current runtime state of an entity, not by its permissions.  This list may include the following operations for a HostSystem: - *HostSystem.EnterMaintenanceMode_Task* - *HostSystem.ExitMaintenanceMode_Task* - *HostSystem.RebootHost_Task* - *HostSystem.ShutdownHost_Task* - *HostSystem.ReconnectHost_Task* - *HostSystem.DisconnectHost_Task*    This list may include the following operations for a VirtualMachine: - *VirtualMachine.AnswerVM* - *ManagedEntity.Rename_Task* - *VirtualMachine.CloneVM_Task* - *VirtualMachine.PowerOffVM_Task* - *VirtualMachine.PowerOnVM_Task* - *VirtualMachine.SuspendVM_Task* - *VirtualMachine.ResetVM_Task* - *VirtualMachine.ReconfigVM_Task* - *VirtualMachine.RelocateVM_Task* - *VirtualMachine.MigrateVM_Task* - *VirtualMachine.CustomizeVM_Task* - *VirtualMachine.ShutdownGuest* - *VirtualMachine.StandbyGuest* - *VirtualMachine.RebootGuest* - *VirtualMachine.CreateSnapshot_Task* - *VirtualMachine.RemoveAllSnapshots_Task* - *VirtualMachine.RevertToCurrentSnapshot_Task* - *VirtualMachine.MarkAsTemplate* - *VirtualMachine.MarkAsVirtualMachine* - *VirtualMachine.ResetGuestInformation* - *VirtualMachine.MountToolsInstaller* - *VirtualMachine.UnmountToolsInstaller* - *ManagedEntity.Destroy_Task* - *VirtualMachine.UpgradeVM_Task* - *VirtualMachine.ExportVm*    This list may include the following operations for a ResourcePool: - *ResourcePool.ImportVApp* - *ResourcePool.CreateChildVM_Task* - *ResourcePool.UpdateConfig* - *Folder.CreateVM_Task* - *ManagedEntity.Destroy_Task* - *ManagedEntity.Rename_Task*    This list may include the following operations for a VirtualApp: - *ManagedEntity.Destroy_Task* - *VirtualApp.CloneVApp_Task* - *VirtualApp.unregisterVApp_Task* - *VirtualApp.ExportVApp* - *VirtualApp.PowerOnVApp_Task* - *VirtualApp.PowerOffVApp_Task* - *VirtualApp.UpdateVAppConfig*    In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetDisabledMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of operations that are disabled, given the current runtime state of the entity. 
                List<string> result = apiInstance.FolderGetDisabledMethod(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetDisabledMethod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetDisabledMethodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of operations that are disabled, given the current runtime state of the entity. 
    ApiResponse<List<string>> response = apiInstance.FolderGetDisabledMethodWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetDisabledMethodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<string>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergeteffectiverole"></a>
# **FolderGetEffectiveRole**
> List&lt;int&gt; FolderGetEffectiveRole (string moId)

Access rights the current session has to this entity. 

Access rights the current session has to this entity.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetEffectiveRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Access rights the current session has to this entity. 
                List<int> result = apiInstance.FolderGetEffectiveRole(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetEffectiveRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetEffectiveRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Access rights the current session has to this entity. 
    ApiResponse<List<int>> response = apiInstance.FolderGetEffectiveRoleWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetEffectiveRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<int>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetexternallymanagedfolderinfo"></a>
# **FolderGetExternallyManagedFolderInfo**
> FolderExternallyManagedFolderInfo FolderGetExternallyManagedFolderInfo (string moId)

The information of externally managed folder. 

The information of externally managed folder.  This property is only set for the externally managed folder.  ***Since:*** vSphere API Release 9.0.0.0 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetExternallyManagedFolderInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The information of externally managed folder. 
                FolderExternallyManagedFolderInfo result = apiInstance.FolderGetExternallyManagedFolderInfo(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetExternallyManagedFolderInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetExternallyManagedFolderInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The information of externally managed folder. 
    ApiResponse<FolderExternallyManagedFolderInfo> response = apiInstance.FolderGetExternallyManagedFolderInfoWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetExternallyManagedFolderInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**FolderExternallyManagedFolderInfo**](FolderExternallyManagedFolderInfo.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetname"></a>
# **FolderGetName**
> string FolderGetName (string moId)

Name of this entity, unique relative to its parent. 

Name of this entity, unique relative to its parent.  Any / (slash), \\\\ (backslash), character used in this name element will be escaped. Similarly, any % (percent) character used in this name element will be escaped, unless it is used to start an escape sequence. A slash is escaped as %2F or %2f. A backslash is escaped as %5C or %5c, and a percent is escaped as %25.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Name of this entity, unique relative to its parent. 
                string result = apiInstance.FolderGetName(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Name of this entity, unique relative to its parent. 
    ApiResponse<string> response = apiInstance.FolderGetNameWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetnamespace"></a>
# **FolderGetNamespace**
> string FolderGetNamespace (string moId)

The namespace with which the Folder is associated. 

The namespace with which the Folder is associated.  Namespace is a vAPI resource which divides cluster resources and allows administrators to give Kubernetes environments to their development teams. This property is set only at the time of creation and cannot change.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetNamespaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The namespace with which the Folder is associated. 
                string result = apiInstance.FolderGetNamespace(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetNamespace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetNamespaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The namespace with which the Folder is associated. 
    ApiResponse<string> response = apiInstance.FolderGetNamespaceWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetNamespaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetoverallstatus"></a>
# **FolderGetOverallStatus**
> ManagedEntityStatusEnum FolderGetOverallStatus (string moId)

General health of this managed entity. 

General health of this managed entity.  The overall status of the managed entity is computed as the worst status among its alarms and the configuration issues detected on the entity. The status is reported as one of the following values: - red: The entity has alarms or configuration issues with a red status. - yellow: The entity does not have alarms or configuration issues with a   red status, and has at least one with a yellow status. - green: The entity does not have alarms or configuration issues with a   red or yellow status, and has at least one with a green status. - gray: All of the entity's alarms have a gray status and the   configuration status of the entity is not being monitored.    In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetOverallStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // General health of this managed entity. 
                ManagedEntityStatusEnum result = apiInstance.FolderGetOverallStatus(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetOverallStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetOverallStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // General health of this managed entity. 
    ApiResponse<ManagedEntityStatusEnum> response = apiInstance.FolderGetOverallStatusWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetOverallStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedEntityStatusEnum**](ManagedEntityStatusEnum.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetparent"></a>
# **FolderGetParent**
> ManagedObjectReference FolderGetParent (string moId)

Parent of this entity. 

Parent of this entity.  This value is null for the root object and for *VirtualMachine* objects that are part of a *VirtualApp*.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetParentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Parent of this entity. 
                ManagedObjectReference result = apiInstance.FolderGetParent(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetParent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetParentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Parent of this entity. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderGetParentWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetParentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instance of *ManagedEntity*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetpermission"></a>
# **FolderGetPermission**
> List&lt;Permission&gt; FolderGetPermission (string moId)

List of the permissions explicitly defined for this entity. 

List of the permissions explicitly defined for this entity. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of the permissions explicitly defined for this entity. 
                List<Permission> result = apiInstance.FolderGetPermission(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of the permissions explicitly defined for this entity. 
    ApiResponse<List<Permission>> response = apiInstance.FolderGetPermissionWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;Permission&gt;**](Permission.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetrecenttask"></a>
# **FolderGetRecentTask**
> List&lt;ManagedObjectReference&gt; FolderGetRecentTask (string moId)

The set of recent tasks operating on this managed entity. 

The set of recent tasks operating on this managed entity.  This is a subset of *TaskManager.recentTask* belong to this entity. A task in this list could be in one of the four states: pending, running, success or error.  This property can be used to deduce intermediate power states for a virtual machine entity. For example, if the current powerState is \"poweredOn\" and there is a running task performing the \"suspend\" operation, then the virtual machine's intermediate state might be described as \"suspending.\"  Most tasks (such as power operations) obtain exclusive access to the virtual machine, so it is unusual for this list to contain more than one running task. One exception, however, is the task of cloning a virtual machine. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetRecentTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The set of recent tasks operating on this managed entity. 
                List<ManagedObjectReference> result = apiInstance.FolderGetRecentTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetRecentTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetRecentTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The set of recent tasks operating on this managed entity. 
    ApiResponse<List<ManagedObjectReference>> response = apiInstance.FolderGetRecentTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetRecentTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refers instances of *Task*.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergettag"></a>
# **FolderGetTag**
> List&lt;Tag&gt; FolderGetTag (string moId)

The set of tags associated with this managed entity. 

The set of tags associated with this managed entity.  Experimental. Subject to change.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The set of tags associated with this managed entity. 
                List<Tag> result = apiInstance.FolderGetTag(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The set of tags associated with this managed entity. 
    ApiResponse<List<Tag>> response = apiInstance.FolderGetTagWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;Tag&gt;**](Tag.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergettriggeredalarmstate"></a>
# **FolderGetTriggeredAlarmState**
> List&lt;AlarmState&gt; FolderGetTriggeredAlarmState (string moId)

A set of alarm states for alarms triggered by this entity or by its descendants. 

A set of alarm states for alarms triggered by this entity or by its descendants.  Triggered alarms are propagated up the inventory hierarchy so that a user can readily tell when a descendant has triggered an alarm. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Any other version value will not produce any property values as no updates are generated.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetTriggeredAlarmStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // A set of alarm states for alarms triggered by this entity or by its descendants. 
                List<AlarmState> result = apiInstance.FolderGetTriggeredAlarmState(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetTriggeredAlarmState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetTriggeredAlarmStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A set of alarm states for alarms triggered by this entity or by its descendants. 
    ApiResponse<List<AlarmState>> response = apiInstance.FolderGetTriggeredAlarmStateWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetTriggeredAlarmStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;AlarmState&gt;**](AlarmState.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldergetvalue"></a>
# **FolderGetValue**
> List&lt;CustomFieldValue&gt; FolderGetValue (string moId)

List of custom field values. 

List of custom field values.  Each value uses a key to associate an instance of a *CustomFieldStringValue* with a custom field definition.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderGetValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // List of custom field values. 
                List<CustomFieldValue> result = apiInstance.FolderGetValue(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderGetValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderGetValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of custom field values. 
    ApiResponse<List<CustomFieldValue>> response = apiInstance.FolderGetValueWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderGetValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;CustomFieldValue&gt;**](CustomFieldValue.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldermoveintofoldertask"></a>
# **FolderMoveIntoFolderTask**
> ManagedObjectReference FolderMoveIntoFolderTask (string moId, MoveIntoFolderRequestType moveIntoFolderRequestType)

Moves a set of managed entities into this folder. 

Moves a set of managed entities into this folder.  This operation is typically used by clients when they implement a drag-and-drop interface to move a set of objects into a folder.  This operation is transactional only with respect to each individual entity. The set of entities is moved sequentially as specified in the list, and committed one at a time. If the *Folder.MoveIntoFolder_Task* method fails on an object, the method terminates at that point with an exception, leaving the rest of the managed entities in their original location.  The objects that can be moved into a folder depends on the folder's type (as defined by the folder's *Folder.childType* property). For a datacenter folder, only datacenters and datacenter folders can be moved into the folder. For a virtual machine folder, only virtual machines and virtual machine folders can be moved into the folder. For a host folder, ComputeResource objects, host folder objects, and HostSystem objects can be moved into the folder.  Moving a HostSystem into a host folder creates a stand-alone host from a host that is currently part of a ClusterComputeResource. The host must be part of a ClusterComputeResource in the same datacenter and the host must be in maintenance mode. Otherwise, the operation fails.  A ComputeResource with a single root resource pool is created for each HostSystem. The name of the ComputeResource is the DNS or IP address of the host. This operation moves the (physical) host resources out of a cluster. It does not move or change the ResourcePool configuration that is part of the ClusterComputeResource with which the host was associated.  Note that all virtual machines associated with a host are moved with the host into the folder. If there are virtual machines that should not be moved with the host, then migrate them from the host before initiating this operation.  vSphere Lifecycle Manager baselines (previously called vSphere Update Manager VUM) is <a href=\"https://kb.vmware.com/s/article/89519\">deprecated</a> in vCenter 8.0. You can instead manage the lifecycle of the hosts in your environment by using vSphere Lifecycle Manager images (vLCM). A Host moved from image managed cluster to datacenter/host folder will become baseline managed stand-alone host.  For a HostSystem move, the privileges required are Host.Inventory.EditCluster on the source ClusterComputeResource, Host.Inventory.MoveHost on the HostSystem, and Host.Inventory.AddStandaloneHost on the target Folder.  Otherwise, the privilege required for this operation varies depending on this folder's type and is checked against the source container, destination container, and the object: - Folder.Move if the object is a Folder - Datacenter.Move if the object is a Datacenter - Host.Inventory.MoveCluster if the object is a ComputeResource - VirtualMachine.Inventory.Move if the object is a virtual machine   or virtual machine template - DVSwitch.Move if the object is a DistributedVirtualSwitch - Datastore.Move if the object is a datastore - Network.Move if the object is a network    If the object is a HostSystem, the privileges required are Host.Inventory.AddStandaloneHost on the folder, Host.Inventory.MoveHost on the HostSystem, and Host.Inventory.EditCluster on the host's original ComputeResource. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderMoveIntoFolderTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var moveIntoFolderRequestType = new MoveIntoFolderRequestType(); // MoveIntoFolderRequestType | 

            try
            {
                // Moves a set of managed entities into this folder. 
                ManagedObjectReference result = apiInstance.FolderMoveIntoFolderTask(moId, moveIntoFolderRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderMoveIntoFolderTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderMoveIntoFolderTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moves a set of managed entities into this folder. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderMoveIntoFolderTaskWithHttpInfo(moId, moveIntoFolderRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderMoveIntoFolderTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **moveIntoFolderRequestType** | [**MoveIntoFolderRequestType**](MoveIntoFolderRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***DuplicateName***: if this folder already contains an object with the specified name.  ***InvalidFolder***: if a Folder that is a parent of this Folder is part of the list of objects.  ***InvalidState***: if a HostSystem is not part of the same datacenter, not part of a ClusterComputeResource, or not in maintenance mode.  ***NotSupported***: if the entity is being moved into a folder whose *Folder.childType* property is not set to the appropriate value. For example, a VirtualMachine entity cannot be moved into a folder whose ChildType property value does not contain \&quot;VirtualMachine\&quot;.  ***DisallowedOperationOnFailoverHost***: if the host is being moved out of a cluster and was configured as a failover host in that cluster. See *ClusterFailoverHostAdmissionControlPolicy*.  ***VmAlreadyExistsInDatacenter***: if moving a standalone host between datacenters, and one or more of the host&#39;s virtual machines is already registered to a host in the destination datacenter.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderregistervmtask"></a>
# **FolderRegisterVMTask**
> ManagedObjectReference FolderRegisterVMTask (string moId, RegisterVMRequestType registerVMRequestType)

Adds an existing virtual machine to the folder. 

Adds an existing virtual machine to the folder.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  This operation only works if the folder's type is VirtualMachine. In addition to the VirtualMachine.Inventory.Register and Resource.AssignVMToPool privileges, it requires System.Read privilege on the datastore that the existing virtual machine resides on. If the virtual machine is encrypted Cryptographer.RegisterVM is required on the folder, in which the virtual machine is registered. Otherwise, the VM is registered successfully, but is left in the locked state.  ***Required privileges:*** VirtualMachine.Inventory.Register 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderRegisterVMTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var registerVMRequestType = new RegisterVMRequestType(); // RegisterVMRequestType | 

            try
            {
                // Adds an existing virtual machine to the folder. 
                ManagedObjectReference result = apiInstance.FolderRegisterVMTask(moId, registerVMRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderRegisterVMTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderRegisterVMTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds an existing virtual machine to the folder. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderRegisterVMTaskWithHttpInfo(moId, registerVMRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderRegisterVMTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **registerVMRequestType** | [**RegisterVMRequestType**](RegisterVMRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation. The *info.result* property in the *Task* contains the newly registered *VirtualMachine* upon success.  Refers instance of *Task*.  |  -  |
| **500** | ***NotSupported***: if the operation is not supported. For example, templates are not supported directly on hosts. Also, if the operation is invoked on a folder whose *Folder.childType* property is not set to \&quot;VirtualMachine\&quot;.  ***OutOfBounds***: if the maximum number of VMs for this folder has been exceeded. The maximum number is determined by Host.capability.maxSupportedVMs.  ***DuplicateName***: if another virtual machine in the same folder has the target name.  ***AlreadyExists***: if the virtual machine is already registered.  ***InvalidDatastore***: if the operation cannot be performed on the target datastores.  ***NotFound***: if the configuration file is not found on the system.  ***InvalidName***: if the entity name is invalid.  ***InvalidArgument***: if any of the arguments such as host or resource pool are not set to valid values.  ***VmConfigFault***: if the format / configuration of the virtual machine is invalid. Typically, a more specific fault is thrown such as InvalidFormat if the configuration file cannot be read, or InvalidDiskFormat if the disks cannot be read.  ***FileFault***: if there is an error accessing the files on disk.  ***InsufficientResourcesFault***: if this operation would violate a resource usage policy.  ***InvalidState***: if the operation is not allowed in current state of the entities involved.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderreload"></a>
# **FolderReload**
> void FolderReload (string moId)

Reload the entity state. 

Reload the entity state.  Clients only need to call this method if they changed some external state that affects the service without using the Web service interface to perform the change. For example, hand-editing a virtual machine configuration file affects the configuration of the associated virtual machine but the service managing the virtual machine might not monitor the file for changes. In this case, after such an edit, a client would call \"reload\" on the associated virtual machine to ensure the service and its clients have current data for the virtual machine.  ***Required privileges:*** System.Read 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderReloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Reload the entity state. 
                apiInstance.FolderReload(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderReload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderReloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reload the entity state. 
    apiInstance.FolderReloadWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderReloadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderrenametask"></a>
# **FolderRenameTask**
> ManagedObjectReference FolderRenameTask (string moId, RenameRequestType renameRequestType)

Renames this managed entity. 

Renames this managed entity.  Any % (percent) character used in this name parameter must be escaped, unless it is used to start an escape sequence. Clients may also escape any other characters in this name parameter.  See also *ManagedEntity.name*.  ***Required privileges:*** Folder.Rename 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderRenameTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var renameRequestType = new RenameRequestType(); // RenameRequestType | 

            try
            {
                // Renames this managed entity. 
                ManagedObjectReference result = apiInstance.FolderRenameTask(moId, renameRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderRenameTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderRenameTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renames this managed entity. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderRenameTaskWithHttpInfo(moId, renameRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderRenameTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **renameRequestType** | [**RenameRequestType**](RenameRequestType.md) |  |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***DuplicateName***: If another object in the same folder has the target name.  ***InvalidName***: If the new name is not a valid entity name.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="foldersetcustomvalue"></a>
# **FolderSetCustomValue**
> void FolderSetCustomValue (string moId, SetCustomValueRequestType setCustomValueRequestType)

Assigns a value to a custom field. 

Assigns a value to a custom field.  The setCustomValue method requires whichever updatePrivilege is defined as one of the *CustomFieldDef.fieldInstancePrivileges* for the CustomFieldDef whose value is being changed. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderSetCustomValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var setCustomValueRequestType = new SetCustomValueRequestType(); // SetCustomValueRequestType | 

            try
            {
                // Assigns a value to a custom field. 
                apiInstance.FolderSetCustomValue(moId, setCustomValueRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderSetCustomValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderSetCustomValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assigns a value to a custom field. 
    apiInstance.FolderSetCustomValueWithHttpInfo(moId, setCustomValueRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderSetCustomValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **setCustomValueRequestType** | [**SetCustomValueRequestType**](SetCustomValueRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="folderunregisteranddestroytask"></a>
# **FolderUnregisterAndDestroyTask**
> ManagedObjectReference FolderUnregisterAndDestroyTask (string moId)

Recursively unregisters all virtual machines and vApps, and destroys all child virtual machine folders. 

Recursively unregisters all virtual machines and vApps, and destroys all child virtual machine folders.  This is similar to the Destroy\\_Task method, but this method calls UnregisterAndDestroy\\_Task on each virtual machine object instead of calling Destroy\\_Task. This operation applies only to VirtualMachine folders.  UnregisterAndDestroy\\_Task is a recursive operation that destroys the specified virtual machine folder, unregisters all child virtual machine objects, and destroys all child virtual machine folders. When you call UnregisterAndDestroy\\_Task to destroy a virtual machine folder, the system uses the specified folder as a root and traverses its descendant hierarchy, calling UnregisterAndDestroy\\_Task on each virtual machine object and Destroy\\_Task on each virtual machine folder. UnregisterAndDestroy\\_Task is a single operation that treats each recursive call as a single transaction, committing each call to remove an object individually. If a failure occurs, the method terminates at that point with an exception, leaving some or all objects unaffected.  If you are removing virtual machines, you must hold the VirtualMachine.Delete privilege on all of the virtual machines to be unregistered, and on their parent folders. If you are removing virtual applications, you must hold the VApp.Delete privilege on all of the virtual applications to be unregistered, and on their parent folders.  ***Required privileges:*** Folder.Delete 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class FolderUnregisterAndDestroyTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new FolderApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Recursively unregisters all virtual machines and vApps, and destroys all child virtual machine folders. 
                ManagedObjectReference result = apiInstance.FolderUnregisterAndDestroyTask(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FolderApi.FolderUnregisterAndDestroyTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FolderUnregisterAndDestroyTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Recursively unregisters all virtual machines and vApps, and destroys all child virtual machine folders. 
    ApiResponse<ManagedObjectReference> response = apiInstance.FolderUnregisterAndDestroyTaskWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FolderApi.FolderUnregisterAndDestroyTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**ManagedObjectReference**](ManagedObjectReference.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This method returns a *Task* object with which to monitor the operation.  Refers instance of *Task*.  |  -  |
| **500** | ***InvalidState***: if a virtual machine is not powered off or suspended.  ***ConcurrentAccess***: if another client modifies the folder contents before this operation completes.  ***NotSupported***: if the *Folder.childType* property of the folder is not set to \&quot;VirtualMachine\&quot;.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

