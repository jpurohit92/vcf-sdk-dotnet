# Vcenter.ViJson.OpenApi.Model.StoragePlacementAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the action.  This is encoded to differentiate between different types of actions aimed at achieving different goals.  | 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target object on which this action will be applied.  For instance, a migration action will have a virtual machine as its target object, while a host power action will have a host as its target action.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine reference.  It is possible that the VM has not been created, in which case, this property is left unset.  Refers instance of *VirtualMachine*.  | [optional] 
**RelocateSpec** | [**VirtualMachineRelocateSpec**](VirtualMachineRelocateSpec.md) | Specification for placing a virtual machine or a set of virtual disks to a datastore.  | 
**Destination** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target datastore.  Refers instance of *Datastore*.  | 
**SpaceUtilBefore** | **float** | Current space utilization on the target datastore.  Unit: percentage. For example, if set to 70.0, space utilization is 70%. If not set, the value is not available.  | [optional] 
**SpaceDemandBefore** | **float** | Current space demand on the target datastore.  Unit: percentage. For example, if set to 70.0, space demand is 70%. This value include the space demanded by thin provisioned VMs. Hence, it may be higher than 100%. If not set, the value is not available.  | [optional] 
**SpaceUtilAfter** | **float** | Space utilization on the target datastore after placing the virtual disk.  Unit: percentage. For example, if set to 70.0, space utilization is 70%. If not set, the value is not available.  | [optional] 
**SpaceDemandAfter** | **float** | Space demand on the target datastore after placing the virtual disk.  Unit: percentage. For example, if set to 70.0, space demand is 70%. This value include the space demanded by thin provisioned VMs. Hence, it may be higher than 100%. If not set, the value is not available.  | [optional] 
**IoLatencyBefore** | **float** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Current I/O latency on the target datastore.  Unit: millisecond. If not set, the value is not available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

