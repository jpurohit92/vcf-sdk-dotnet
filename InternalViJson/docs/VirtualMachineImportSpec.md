# Vcenter.ViJson.OpenApi.Model.VirtualMachineImportSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityConfig** | [**VAppEntityConfigInfo**](VAppEntityConfigInfo.md) | Configuration of sub-entities (virtual machine or vApp).  This is used for sub-entities of a vApp that could be a virtual machine or a vApp.  | [optional] 
**InstantiationOst** | [**OvfConsumerOstNode**](OvfConsumerOstNode.md) | The instantiation OST (see *OvfConsumer* ) to be consumed by OVF consumers.  | [optional] 
**ConfigSpec** | [**VirtualMachineConfigSpec**](VirtualMachineConfigSpec.md) | Configuration for the virtual machine.  | 
**ResPoolEntity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated as of vSphere API 5.1.  If specified, this resource pool will be used as the parent resource pool and the virtual machine will be made a linked child to the parent vApp.  This field is ignored for the root node in an ImportSpec tree.  Refers instance of *ResourcePool*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

