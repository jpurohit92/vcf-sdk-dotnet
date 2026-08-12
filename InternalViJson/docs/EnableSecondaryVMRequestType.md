# Vcenter.ViJson.OpenApi.Model.EnableSecondaryVMRequestType
The parameters of *VirtualMachine.EnableSecondaryVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The secondary virtual machine specified will be enabled. This field must specify a secondary virtual machine that is part of the fault tolerant group that this virtual machine is currently associated with. It can only be invoked from the primary virtual machine in the group.  Refers instance of *VirtualMachine*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host on which the secondary virtual machine is to be enabled and possibly powered on. If no host is specified, a compatible host will be selected by the system. If the secondary virtual machine is not compatible with the specified host, the secondary will not be re-enabled and a fault will be returned.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

