# Vcenter.ViJson.OpenApi.Model.CheckCompatibilityRequestType
The parameters of *VirtualMachineCompatibilityChecker.CheckCompatibility_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine we&#39;d like to place.  Refers instance of *VirtualMachine*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host we would like the virtual machine to execute on. The host parameter may be left unset if the compute resource associated with the pool represents a stand-alone host or a DRS-enabled cluster. In the former case the stand-alone host is used. In the latter case, each connected host in the cluster that is not in maintenance mode is tested. If the virtual machine is a template then either this parameter or the pool parameter must be set.  Refers instance of *HostSystem*.  | [optional] 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool we would like the virtual machine to reside in. If the pool parameter is left unset, then the virtual machine&#39;s current pool is assumed. If the virtual machine is a template then either this parameter or the host parameter must be set.  Refers instance of *ResourcePool*.  | [optional] 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run. See *CheckTestType_enum* for possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

