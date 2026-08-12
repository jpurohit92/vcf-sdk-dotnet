# Vcenter.ViJson.OpenApi.Model.MigrateVMRequestType
The parameters of *VirtualMachine.MigrateVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target resource pool for the virtual machine. If the pool parameter is left unset, the virtual machine&#39;s current pool is used as the target pool.  ***Required privileges:*** Resource.AssignVMToPool  Refers instance of *ResourcePool*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host to which the virtual machine is intended to migrate. The host parameter may be left unset if the compute resource associated with the target pool represents a stand-alone host or a DRS-enabled cluster. In the former case the stand-alone host is used as the target host. In the latter case, the DRS system selects an appropriate target host from the cluster.  Refers instance of *HostSystem*.  | [optional] 
**Priority** | **VirtualMachineMovePriorityEnum** | The task priority (@see vim.VirtualMachine.MovePriority).  | 
**State** | **VirtualMachinePowerStateEnum** | If specified, the virtual machine migrates only if its state matches the specified state.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

