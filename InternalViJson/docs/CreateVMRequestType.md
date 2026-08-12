# Vcenter.ViJson.OpenApi.Model.CreateVMRequestType
The parameters of *Folder.CreateVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**VirtualMachineConfigSpec**](VirtualMachineConfigSpec.md) | The configuration of the virtual machine hardware.  | 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool to which the virtual machine will be attached.  ***Required privileges:*** Resource.AssignVMToPool  Refers instance of *ResourcePool*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the virtual machine will run. This must specify a host that is a member of the ComputeResource indirectly specified by the pool. For a stand-alone host or a cluster with DRS, host can be omitted, and the system selects a default.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

