# Vcenter.ViJson.OpenApi.Model.CheckVmConfigRequestType
The parameters of *VirtualMachineCompatibilityChecker.CheckVmConfig_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Spec** | [**VirtualMachineConfigSpec**](VirtualMachineConfigSpec.md) | The specification of the virtual machine to create.  | 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The existing virtual machine to apply the spec to. If this is not provided, the spec is assumed to be for the creation of a new virtual machine.  Refers instance of *VirtualMachine*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host we would like the virtual machine to execute on. The host parameter may be left unset if the compute resource associated with the pool represents a stand-alone host or a DRS-enabled cluster. In the former case the stand-alone host is used. In the latter case, each connected host in the cluster that is not in maintenance mode is tested. If the virtual machine is a template, then either this parameter or the pool parameter must be set.  Refers instance of *HostSystem*.  | [optional] 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool we would like the virtual machine to reside in. If the pool parameter is left unset, then we use the host&#39;s root resource pool.  Refers instance of *ResourcePool*.  | [optional] 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run. See *CheckTestType_enum* for possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

