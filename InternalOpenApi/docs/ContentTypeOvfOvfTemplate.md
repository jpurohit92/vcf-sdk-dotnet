# Vcenter.Automation.OpenApi.Model.ContentTypeOvfOvfTemplate
Provides extra information about a library item of type \"ovf\".    An OVF library item is the basic building block for instantiating virtual machines from content library. It may contain one or multiple virtual machine templates. This structure provides a rich view of the virtual machines within the ovf container as well as information about to the ovf descriptor associated with the library item 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Library item id.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. | 
**VmCount** | **long** | Number of virtual machines in the the ovf template. | 
**VarVersion** | **string** | A version number indicating the generation of the &#x60;OvfTemplate&#x60;    This value is incremented every time &#x60;OvfTemplate&#x60; changes.  | 
**LibraryIdParent** | **string** | The identifier of the *Content.LibraryModel* to which this item belongs. This is used to set the parent of the ovf template for permission propagation.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | 
**IsVappTemplate** | **bool** | True if this is a vApp template, otherwise this is a VM template. | 
**VmTemplate** | [**ContentTypeOvfVmTemplate**](ContentTypeOvfVmTemplate.md) | The Vitrual Machine if this is a VM template  An OVF template does not require a VM template. | [optional] 
**VappTemplate** | [**ContentTypeOvfVAppTemplate**](ContentTypeOvfVAppTemplate.md) | The root VApp template in this OVF template if this is a vApp template  An OVF template does not require a vApp template. | [optional] 
**Networks** | [**List&lt;ContentTypeOvfNetwork&gt;**](ContentTypeOvfNetwork.md) | networks in this OVF template | 
**StoragePolicyGroups** | [**List&lt;ContentTypeOvfPolicyStoragePolicyGroup&gt;**](ContentTypeOvfPolicyStoragePolicyGroup.md) | Storage policy groups for disks, virtual machines and/or virtual machine collections.  An OVF template does not require policies. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

