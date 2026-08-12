# Vcenter.Automation.OpenApi.Model.ContentLibraryItemUpdatesessionFileAddSpec
The Content.Library.Item.Updatesession.File.AddSpec schema describes the properties of the file to be uploaded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the file being uploaded. | 
**SourceType** | **string** | The source type (SourceType) from which the file content will be retrieved.  Possible values:   - &#x60;NONE&#x60;: No source type has been requested.   - &#x60;PUSH&#x60;: The client is uploading content using HTTP(S) PUT requests.   - &#x60;PULL&#x60;: The server is pulling content from a URL. The URL scheme can be &#x60;http&#x60;, &#x60;https&#x60;, &#x60;file&#x60;, or &#x60;ds&#x60;.   For more information see: *Content.Library.Item.Updatesession.File.SourceType*. | 
**SourceEndpoint** | [**ContentLibraryItemTransferEndpoint**](ContentLibraryItemTransferEndpoint.md) | Location from which the Content Library Service will fetch the file, rather than requiring a client to upload the file.  This property is optional and it is only relevant when the value of source_type is *Content.Library.Item.Updatesession.File.SourceType.PULL*. | [optional] 
**Size** | **long** | The file size, in bytes.  If missing or &#x60;null&#x60;, the server will not verify it received the correct size. | [optional] 
**ChecksumInfo** | [**ContentLibraryItemFileChecksumInfo**](ContentLibraryItemFileChecksumInfo.md) | The checksum of the file. If specified, the server will verify the checksum once the file is received. If there is a mismatch, the upload will fail. For ova files, this value should not be set.  If missing or &#x60;null&#x60;, the server will not verify the checksum. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

