# Vcenter.Automation.OpenApi.Model.VcenterTaggingTagsListItem
The Vcenter.Tagging.Tags.ListItem schema contains the tag identifier and further information about the tag.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tag** | **string** | The identifier of the tag.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. | 
**Info** | [**VcenterTaggingTagsInfo**](VcenterTaggingTagsInfo.md) | The information about the tag.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

