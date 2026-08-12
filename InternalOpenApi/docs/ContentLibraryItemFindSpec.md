# Vcenter.Automation.OpenApi.Model.ContentLibraryItemFindSpec
The Content.Library.Item.FindSpec schema specifies the properties that can be used as a filter to find library items. When multiple properties are specified, all properties of the item must match the specification.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the library item. The name is case-insensitive. See *Content.Library.ItemModel.name*.  If not specified all library item names are searched. | [optional] 
**LibraryId** | **string** | The identifier of the library containing the item. See *Content.Library.ItemModel.library_id*.  If not specified all libraries are searched.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | [optional] 
**SourceId** | **string** | The identifier of the library item as reported by the publisher. See *Content.Library.ItemModel.source_id*.  If not specified all library items are searched.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. | [optional] 
**Type** | **string** | The type of the library item. The type is case-insensitive. See *Content.Library.ItemModel.type*.  If not specified all types are searched. | [optional] 
**Cached** | **bool** | Whether the item is cached. Possible values are &#39;true&#39; or &#39;false&#39;. See *Content.Library.ItemModel.cached*.  If not specified all library items are searched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

