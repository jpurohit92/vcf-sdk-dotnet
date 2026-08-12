# Vcenter.ViJson.OpenApi.Model.CloneVMRequestType
The parameters of *VirtualMachine.CloneVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Folder** | [**ManagedObjectReference**](ManagedObjectReference.md) | The location of the new virtual machine.  Refers instance of *Folder*.  | 
**Name** | **string** | The name of the new virtual machine.  | 
**Spec** | [**VirtualMachineCloneSpec**](VirtualMachineCloneSpec.md) | Specifies how to clone the virtual machine. The folder specified in the spec takes precedence over the folder parameter.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

