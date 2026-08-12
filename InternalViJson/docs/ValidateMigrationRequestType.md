# Vcenter.ViJson.OpenApi.Model.ValidateMigrationRequestType
The parameters of *ServiceInstance.ValidateMigration*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of virtual machines intended for migration.  Refers instances of *VirtualMachine*.  | 
**State** | **VirtualMachinePowerStateEnum** | The power state that the virtual machines must have. If this argument is not set, each virtual machine is evaluated according to its current power state.  | [optional] 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run.  | [optional] 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target resource pool for the virtual machines. If the pool parameter is left unset, the target pool for each particular virtual machine&#39;s migration will be that virtual machine&#39;s current pool. If the virtual machine is a template then either this parameter or the host parameter must be set; additionally if resource tests are requested then this parameter is required.  Refers instance of *ResourcePool*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host on which the virtual machines will run. The host parameter may be left unset if the compute resource associated with the target pool represents a stand-alone host or a DRS-enabled cluster. In the former case the stand-alone host is used as the target host. In the latter case, each connected host in the cluster that is not in maintenance mode is tested as a target host. If the virtual machine is a template then either this parameter or the pool parameter must be set.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

