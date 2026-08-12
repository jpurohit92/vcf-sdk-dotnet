# Vcenter.ViJson.OpenApi.Model.CheckInstantCloneRequestType
The parameters of *VirtualMachineProvisioningChecker.CheckInstantClone_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine we propose to instant clone.  Refers instance of *VirtualMachine*.  | 
**Spec** | [**VirtualMachineInstantCloneSpec**](VirtualMachineInstantCloneSpec.md) | Specifies how to instant clone the virtual machine.  | 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run. See *CheckTestType_enum* for possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

