# Vcenter.ViJson.OpenApi.Model.MarkAsVirtualMachineRequestType
The parameters of *VirtualMachine.MarkAsVirtualMachine*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | Resource pool to associate with the virtual machine.  ***Required privileges:*** Resource.AssignVMToPool  Refers instance of *ResourcePool*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the virtual machine is intended to run. The host parameter must specify a host that is a member of the ComputeResource indirectly specified by the pool. For a stand-alone host or a cluster with DRS, it can be omitted and the system selects a default.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

