# Vcenter.Automation.OpenApi.Model.ContentLibraryItemUpdatesessionFileInfo
The Content.Library.Item.Updatesession.File.Info schema defines the uploaded file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the file. | 
**SourceType** | **string** | The source type (SourceType) from which the file is being retrieved. This may be *Content.Library.Item.Updatesession.File.SourceType.NONE* if the file is not being changed.  Possible values:   - &#x60;NONE&#x60;: No source type has been requested.   - &#x60;PUSH&#x60;: The client is uploading content using HTTP(S) PUT requests.   - &#x60;PULL&#x60;: The server is pulling content from a URL. The URL scheme can be &#x60;http&#x60;, &#x60;https&#x60;, &#x60;file&#x60;, or &#x60;ds&#x60;.   For more information see: *Content.Library.Item.Updatesession.File.SourceType*. | 
**Size** | **long** | The file size, in bytes as received by the server. This property is guaranteed to be set when the server has completely received the file.  This property won&#39;t be set until the file status is *Content.Library.Item.TransferStatus.READY*. | [optional] 
**ChecksumInfo** | [**ContentLibraryItemFileChecksumInfo**](ContentLibraryItemFileChecksumInfo.md) | The checksum information of the file received by the server.  If missing or &#x60;null&#x60;, the server does not verify the checksum. | [optional] 
**SourceEndpoint** | [**ContentLibraryItemTransferEndpoint**](ContentLibraryItemTransferEndpoint.md) | A source endpoint from which to retrieve the file.  This property is optional and it is only relevant when the value of source_type is *Content.Library.Item.Updatesession.File.SourceType.PULL*. | [optional] 
**UploadEndpoint** | [**ContentLibraryItemTransferEndpoint**](ContentLibraryItemTransferEndpoint.md) | An upload endpoint to which the client can push the content.  This property is optional and it is only relevant when the value of source_type is *Content.Library.Item.Updatesession.File.SourceType.PUSH*. | [optional] 
**BytesTransferred** | **long** | The number of bytes of this file that have been received by the server. | 
**Status** | **string** | The transfer status (TransferStatus) of this file.  Possible values:   - &#x60;WAITING_FOR_TRANSFER&#x60;: Indicates that a file has been defined for a library item and its content needs to be uploaded.   - &#x60;TRANSFERRING&#x60;: Indicates that data is being transferred to the file.   - &#x60;READY&#x60;: Indicates that the file has been fully transferred and is ready to be used.   - &#x60;VALIDATING&#x60;: Indicates that the file is being validated (checksum, type adapters).   - &#x60;ERROR&#x60;: Indicates that there was an error transferring or validating the file.   For more information see: *Content.Library.Item.TransferStatus*. | 
**ErrorMessage** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the transfer error.  An error message is set if the status is *Content.Library.Item.TransferStatus.ERROR*. | [optional] 
**KeepInStorage** | **bool** | Whether or not the file will be kept in storage upon update session completion. The flag is true for most files, and false for metadata files such as manifest and certificate file of update session with library item type OVF. Any file with *Content.Library.Item.Updatesession.File.Info.keep_in_storage* set to false will not show up in the list of files returned from *GET /content/library/item/{libraryItemId}/file* upon update session completion.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, the file will be kept in storage upon update session completion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

