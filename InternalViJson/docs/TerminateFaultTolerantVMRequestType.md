# Vcenter.ViJson.OpenApi.Model.TerminateFaultTolerantVMRequestType
The parameters of *VirtualMachine.TerminateFaultTolerantVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The secondary virtual machine specified will be terminated, allowing fault tolerance to activate. If no virtual machine is specified, all secondary virtual machines will be terminated. If vm is a primary, InvalidArgument exception is thrown. This field must specify a virtual machine that is part of the fault tolerant group that this virtual machine is currently associated with. It can only be invoked from the primary virtual machine in the group. If the primary virtual machine is terminated, an available secondary virtual machine will be promoted to primary. If no secondary exists, an exception will be thrown and the primary virtual machine will not be terminated. If a secondary virtual machine is terminated, it may be respawned on a potentially different host.  Refers instance of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

