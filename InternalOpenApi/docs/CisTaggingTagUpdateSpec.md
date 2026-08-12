# Vcenter.Automation.OpenApi.Model.CisTaggingTagUpdateSpec
The Cis.Tagging.Tag.UpdateSpec schema describes the updates to be made to an existing tag.    Use the *PATCH /cis/tagging/tag/{tagId}* operation to modify a tag. When you call the operation, you specify the tag identifier. You obtain the tag identifier when you call the *POST /cis/tagging/tag* operation. You can also retrieve an identifier by using the *GET /cis/tagging/tag* operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The display name of the tag.  If missing or &#x60;null&#x60; the name will not be modified. | [optional] 
**Description** | **string** | The description of the tag.  If missing or &#x60;null&#x60; the description will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

