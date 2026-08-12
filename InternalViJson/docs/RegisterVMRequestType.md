# Vcenter.ViJson.OpenApi.Model.RegisterVMRequestType
The parameters of *Folder.RegisterVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | A datastore path to the virtual machine.  | 
**Name** | **string** | The name to be assigned to the virtual machine. If this parameter is not set, the displayName configuration parameter of the virtual machine is used. An entity name must be a non-empty string of less than 80 characters. The slash (/), backslash (\\\\) and percent (%) will be escaped using the URL syntax. For example, %2F.  | [optional] 
**AsTemplate** | **bool** | Flag to specify whether or not the virtual machine should be marked as a template.  | 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool to which the virtual machine should be attached. If imported as a template, this parameter is not set.  ***Required privileges:*** Resource.AssignVMToPool  Refers instance of *ResourcePool*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the virtual machine will run. This parameter must specify a host that is a member of the ComputeResource indirectly specified by the pool. For a stand-alone host or a cluster, the parameter can be omitted, and the system selects a default.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

