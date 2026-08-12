# Vcenter.ViJson.OpenApi.Model.CheckPowerOnRequestType
The parameters of *VirtualMachineCompatibilityChecker.CheckPowerOn_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to power on.  Refers instance of *VirtualMachine*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host on which we want to power on the virtual machine. The host parameter may be left unset if the compute resource associated with the pool represents a stand-alone host or a DRS-enabled cluster. In the former case the stand-alone host is used. In the latter case, each connected host in the cluster that is not in maintenance mode is tested. Either this parameter or the pool parameter must be set.  Refers instance of *HostSystem*.  | [optional] 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool we would like the virtual machine to run in. If the pool parameter is left unset, we use the host&#39;s root resource pool.  Refers instance of *ResourcePool*.  | [optional] 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run. See *CheckTestType_enum* for possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

