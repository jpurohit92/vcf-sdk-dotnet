# Vcenter.ViJson.OpenApi.Model.CheckRelocateRequestType
The parameters of *VirtualMachineProvisioningChecker.CheckRelocate_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine we propose to relocate.  Refers instance of *VirtualMachine*.  | 
**Spec** | [**VirtualMachineRelocateSpec**](VirtualMachineRelocateSpec.md) | The specification of where to relocate the virtual machine. In cases where DRS would automatically select a host, all potential hosts are tested against. The host parameter in the spec may be left unset for checking feasibility of relocation to a different datacenter or different vCenter service, if the compute resource associated with the target pool represents a stand-alone host, the host is tested against, otherwise each connected host in the cluster that is not in maintenance mode represented by the target pool is tested as a target host.  | 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run. See *CheckTestType_enum* for possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

