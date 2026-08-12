# Vcenter.ViJson.OpenApi.Model.CreateChildVMRequestType
The parameters of *ResourcePool.CreateChildVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**VirtualMachineConfigSpec**](VirtualMachineConfigSpec.md) | The configuration of the virtual machine hardware.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the virtual machine will run. This must specify a host that is a member of the ComputeResource indirectly specified by the pool. For a stand-alone host or a cluster with DRS, host can be omitted, and the system selects a default.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

