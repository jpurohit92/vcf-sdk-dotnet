# Vcenter.ViJson.OpenApi.Model.CheckCloneRequestType
The parameters of *VirtualMachineProvisioningChecker.CheckClone_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine we propose to clone.  Refers instance of *VirtualMachine*.  | 
**Folder** | [**ManagedObjectReference**](ManagedObjectReference.md) | The location of the new virtual machine.  Refers instance of *Folder*.  | 
**Name** | **string** | The name of the new virtual machine.  | 
**Spec** | [**VirtualMachineCloneSpec**](VirtualMachineCloneSpec.md) | Specifies how to clone the virtual machine. In cases where DRS would automatically select a host, all potential hosts are tested against.  | 
**TestType** | **List&lt;string&gt;** | The set of tests to run. If this argument is not set, all tests will be run. See *CheckTestType_enum* for possible values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

