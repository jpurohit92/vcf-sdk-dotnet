# Vcenter.Automation.OpenApi.Model.VcenterTaggingTagsInfo
The Vcenter.Tagging.Tags.Info schema contains the tag Name and Category ID  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the tag.  This property was added in __vSphere API 9.0.0.0__. | 
**Category** | **string** | Category Id  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. | 
**Description** | **string** | The description of the Tag.  This property was added in __vSphere API 9.0.0.0__. | 
**UsedBy** | **List&lt;string&gt;** | The set of users that can use this Tag.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

