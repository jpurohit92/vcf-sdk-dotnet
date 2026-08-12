# Vcenter.Automation.OpenApi.Model.ContentLibraryItemChangesSummary
The Content.Library.Item.Changes.Summary schema contains commonly used information about a library item change.  This schema was added in __vSphere API 6.9.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The version of the library item.  This property was added in __vSphere API 6.9.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.item.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.item.Version&#x60;. | 
**Time** | **DateTime** | The date and time when the item content was changed.  This property was added in __vSphere API 6.9.1__. | 
**User** | **string** | The user who made the content change.  This property was added in __vSphere API 6.9.1__.  This property will be missing or &#x60;null&#x60; if the user could not be determined. | [optional] 
**ShortMessage** | **string** | The short message describing the content change. The message is truncated to the first 80 characters or first non-leading newline character, whichever length is shorter.  This property was added in __vSphere API 6.9.1__.  This property will be missing or &#x60;null&#x60; if a message was not provided when the item content was changed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

