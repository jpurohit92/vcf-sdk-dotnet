# Vcenter.ViJson.OpenApi.Model.LocalizationManagerMessageCatalog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModuleName** | **string** | The module or extension that publishes this catalog.  The moduleName will be empty for the core catalogs for the VirtualCenter server itself.  | 
**CatalogName** | **string** | The name of the catalog.  | 
**Locale** | **string** | The locale for the catalog.  | 
**CatalogUri** | **string** | The URI (relative to the connection URL for the VirtualCenter server itself) from which the catalog can be downloaded.  The caller will need to augment this with a scheme and authority (host and port) to make a complete URL.  | 
**LastModified** | **DateTime** | The last-modified time of the catalog file, if available  | [optional] 
**Md5sum** | **string** | The checksum of the catalog file, if available  | [optional] 
**VarVersion** | **string** | The version of the catalog file, if available The format is dot-separated version string, e.g.  \&quot;1.2.3\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

