# Vcenter.Automation.OpenApi.Model.ContentLibraryItemFileInfo
The Content.Library.Item.File.Info schema provides information about a file in Content Library Service storage.    A file is an actual stored object for a library item. An item will have zero files initially, but one or more can be uploaded to the item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChecksumInfo** | [**ContentLibraryItemFileChecksumInfo**](ContentLibraryItemFileChecksumInfo.md) | A checksum for validating the content of the file.    This value can be used to verify that a transfer was completed without errors.  A checksum cannot always be calculated, and the value will be missing or &#x60;null&#x60; if the file does not have content. | [optional] 
**Name** | **string** | The name of the file.    This value will be unique within the library item for each file. It cannot be an empty string. | 
**Size** | **long** | The file size, in bytes. The file size is the storage used and not the uploaded or provisioned size. For example, when uploading a disk to a datastore, the amount of storage that the disk consumes may be different from the disk file size. When the file is not cached, the size is 0. | 
**Cached** | **bool** | Indicates whether the file is on disk or not. | 
**VarVersion** | **string** | The version of this file; incremented when a new copy of the file is uploaded. | 
**FileDownloadEndpoint** | **string** | The URL endpoint that can be used to download the file.    Eg URL: https://{vc}/cls/static/{libraryId}/{itemId}/{fileName}?version&#x3D;{version} *Content.Library.Item.File.Info.version* query param in the URL specifies the latest version of the file present in storage. When URL is hit with version query param, the file version specified in version query param is downloaded. The download will fail with 404 not found error if the specified version is no longer present in storage. If URL is hit without version query param, the latest file version present in storage is downloaded.    It is expected to provide API session i.e. vmware-api-session-id in header while using the URL to download the file. vmware-api-session-id can be obtained from *POST /session* operation Eg: wget - -header&#x3D;\&quot;vmware-api-session-id: {sessionId}\&quot; fileDownloadEndpoint  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the file is not present in storage i.e *Content.Library.Item.File.Info.cached* is False or library item is of VMTX Template type (as download of VMTX template is not supported currently) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

