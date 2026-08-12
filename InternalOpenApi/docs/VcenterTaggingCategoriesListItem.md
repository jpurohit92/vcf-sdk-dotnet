# Vcenter.Automation.OpenApi.Model.VcenterTaggingCategoriesListItem
The Vcenter.Tagging.Categories.ListItem schema contains the category identifier and further information about the category.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryId** | **string** | The identifier of the category.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. | 
**Info** | [**VcenterTaggingCategoriesInfo**](VcenterTaggingCategoriesInfo.md) | The information about the category.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

