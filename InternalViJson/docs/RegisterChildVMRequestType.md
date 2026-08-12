# Vcenter.ViJson.OpenApi.Model.RegisterChildVMRequestType
The parameters of *ResourcePool.RegisterChildVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | A datastore path to the virtual machine. If the path ends with \&quot;.vmtx\&quot;, indicating that it refers to a VM template, an InvalidArgument fault is thrown.  | 
**Name** | **string** | The name to be assigned to the virtual machine. If this parameter is not set, the displayName configuration parameter of the virtual machine is used. An entity name must be a non-empty string of less than 80 characters. The slash (/), backslash (\\\\) and percent (%) will be escaped using the URL syntax. For example, %2F.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the virtual machine will run. This parameter must specify a host that is a member of the ComputeResource to which this resource pool belongs. For a stand-alone host or a cluster with DRS, the parameter can be omitted, and the system selects a default.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

