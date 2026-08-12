# Vcenter.Automation.OpenApi.Model.ContentLibraryItemChangesInfo
The Content.Library.Item.Changes.Info schema contains information about a library item change.  This schema was added in __vSphere API 6.9.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **DateTime** | The date and time when the item content was changed.  This property was added in __vSphere API 6.9.1__. | 
**User** | **string** | The user who made the content change.  This property was added in __vSphere API 6.9.1__.  This property will be missing or &#x60;null&#x60; if the user could not be determined. | [optional] 
**Message** | **string** | The full message describing the content change.  This property was added in __vSphere API 6.9.1__.  This property will be missing or &#x60;null&#x60; if a message was not provided when the item content was changed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

