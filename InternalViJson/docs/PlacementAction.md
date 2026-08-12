# Vcenter.ViJson.OpenApi.Model.PlacementAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the action.  This is encoded to differentiate between different types of actions aimed at achieving different goals.  | 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target object on which this action will be applied.  For instance, a migration action will have a virtual machine as its target object, while a host power action will have a host as its target action.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine reference.  Unset if the VM has not been created.  Refers instance of *VirtualMachine*.  | [optional] 
**TargetHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host where the virtual machine should be placed.  Unset if no host recommendation is provided.  Refers instance of *HostSystem*.  | [optional] 
**RelocateSpec** | [**VirtualMachineRelocateSpec**](VirtualMachineRelocateSpec.md) | Specification for placing the configuration files and the virtual disks of the virtual machine on one or more datastores.  Unset if no datastore recommendation is provided.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

