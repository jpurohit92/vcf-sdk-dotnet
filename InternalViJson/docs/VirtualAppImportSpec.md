# Vcenter.ViJson.OpenApi.Model.VirtualAppImportSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityConfig** | [**VAppEntityConfigInfo**](VAppEntityConfigInfo.md) | Configuration of sub-entities (virtual machine or vApp).  This is used for sub-entities of a vApp that could be a virtual machine or a vApp.  | [optional] 
**InstantiationOst** | [**OvfConsumerOstNode**](OvfConsumerOstNode.md) | The instantiation OST (see *OvfConsumer* ) to be consumed by OVF consumers.  | [optional] 
**Name** | **string** | The name of the vApp  | 
**VAppConfigSpec** | [**VAppConfigSpec**](VAppConfigSpec.md) | vApp configuration  | 
**ResourcePoolSpec** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | Resource pool specification.  If resourcePoolSpec.entity is specified, that resource pool is used as the parent resource pool and the vApp will be made a linked child to the parent vApp. This field is ignored for the root node in an ImportSpec tree. Use of resourcePoolSpec.entity for creating linked children is deprecated as of vSphere API 5.1.  | 
**Child** | [**List&lt;ImportSpec&gt;**](ImportSpec.md) | Contains a list of children (*VirtualMachine*s and *VirtualApp*s).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

