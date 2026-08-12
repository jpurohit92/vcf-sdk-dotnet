# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsVersionsSummary
The Vcenter.VmTemplate.LibraryItems.Versions.Summary schema contains commonly used information about a version of a library item containing a virtual machine template.  This schema was added in __vSphere API 6.9.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The version of the library item.  This property was added in __vSphere API 6.9.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.item.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.item.Version&#x60;. | 
**VmTemplate** | **string** | Identifier of the virtual machine template associated with the library item version. This property is the managed object identifier used to identify the virtual machine template in the vSphere Management (SOAP) API.  This property was added in __vSphere API 6.9.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

