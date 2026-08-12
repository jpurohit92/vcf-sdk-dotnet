# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsEthernetUpdateSpec
The Vcenter.VmTemplate.LibraryItems.EthernetUpdateSpec schema describes the network that the ethernet adapter of the deployed virtual machine should be connected to.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | Identifier of the network backing the virtual Ethernet adapter.  This property was added in __vSphere API 6.8__.  This property is currently required.    If missing or &#x60;null&#x60;, the virtual Ethernet adapter will be connected to same network as it was in the source virtual machine template.   When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | [optional] 
**Subnet** | **string** | The Identifier of the subnet the virtual ethernet adapter connects to. It is only set when the virtual network adapter is connected to a subnet. If set, this will take precedence over the *Vcenter.VmTemplate.LibraryItems.EthernetUpdateSpec.network* property. If missing or &#x60;null&#x60;, virtual network adapter will not be connected to a subnet  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

