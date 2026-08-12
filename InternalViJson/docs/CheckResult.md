# Vcenter.ViJson.OpenApi.Model.CheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine involved in the testing.  Refers instance of *VirtualMachine*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host involved in the testing.  Refers instance of *HostSystem*.  | [optional] 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) | A list of faults representing problems which may require attention, but which are not fatal.  | [optional] 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | A list of faults representing problems which are fatal to the operation.  For *VirtualMachineProvisioningChecker* an error means that the given provisioning operation would fail. For *VirtualMachineCompatibilityChecker* an error means that either a power-on of this virtual machine would fail, or that the virtual machine would not run correctly once powered-on.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

