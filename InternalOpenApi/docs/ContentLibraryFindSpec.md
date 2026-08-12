# Vcenter.Automation.OpenApi.Model.ContentLibraryFindSpec
Specifies the properties that can be used as a filter to find libraries. When multiple properties are specified, all properties of the library must match the specification.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the library to search. The name is case-insensitive. See *Content.LibraryModel.name*.  If not specified any name will be searched. | [optional] 
**Type** | **string** | Library type to search. See *Content.LibraryModel.type*.  Possible values:   - &#x60;LOCAL&#x60;: The library contents are defined and stored by the local Content Library Service installation.    A local library can be retrieved and managed via the *Content.LocalLibrary*.   - &#x60;SUBSCRIBED&#x60;: The library synchronizes its items and content from another published library.    A subscribed library can be retrieved and managed via the *Content.SubscribedLibrary*.   For more information see: *Content.LibraryModel.LibraryType*.  If not specified any library type will be searched. | [optional] 
**StorageBacking** | [**ContentLibraryStorageBacking**](ContentLibraryStorageBacking.md) | Library StorageBacking to search. See *Content.Library.StorageBacking*.  This property was added in __vSphere API 9.0.0.0__.  If not specified any storage backing will be searched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

