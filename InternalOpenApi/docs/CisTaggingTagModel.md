# Vcenter.Automation.OpenApi.Model.CisTaggingTagModel
The Cis.Tagging.TagModel schema defines a tag that can be attached to vSphere objects.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the tag.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. | 
**CategoryId** | **string** | The identifier of the parent category in which this tag will be created.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. | 
**Name** | **string** | The display name of the tag. | 
**Description** | **string** | The description of the tag. | 
**UsedBy** | **List&lt;string&gt;** | The set of users that can use this tag. To add users to this, you need to have the edit privilege on the tag. Similarly, to unsubscribe from this tag, you need the edit privilege on the tag. You should not modify other users subscription from this set. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

