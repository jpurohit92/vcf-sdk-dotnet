# Vcenter.Automation.OpenApi.Model.ContentLibraryItemDownloadsessionFileInfo
The Content.Library.Item.Downloadsession.File.Info schema defines the downloaded file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the file. | 
**Size** | **long** | The file size, in bytes.  This property may not be available immediately. It is guaranteed to be set when the client finishes downloading the file. | [optional] 
**BytesTransferred** | **long** | The number of bytes that have been transferred by the server so far for making this file prepared for download. This value may stay at zero till the client starts downloading the file. | 
**Status** | **string** | The preparation status (PrepareStatus) of the file.  Possible values:   - &#x60;UNPREPARED&#x60;: The file hasn&#39;t been requested for preparation.   - &#x60;PREPARE_REQUESTED&#x60;: A prepare has been requested, however the server hasn&#39;t started the preparation yet.   - &#x60;PREPARING&#x60;: A prepare has been requested and the file is in the process of being prepared.   - &#x60;PREPARED&#x60;: Prepare succeeded. The file is ready for download.   - &#x60;ERROR&#x60;: Prepare failed.   For more information see: *Content.Library.Item.Downloadsession.File.PrepareStatus*. | 
**DownloadEndpoint** | [**ContentLibraryItemTransferEndpoint**](ContentLibraryItemTransferEndpoint.md) | Endpoint at which the file is available for download. The value is valid only when the *Content.Library.Item.Downloadsession.File.Info.status* is *Content.Library.Item.Downloadsession.File.PrepareStatus.PREPARED*.  This property won&#39;t be set until the file status is *Content.Library.Item.Downloadsession.File.PrepareStatus.PREPARED*. | [optional] 
**ChecksumInfo** | [**ContentLibraryItemFileChecksumInfo**](ContentLibraryItemFileChecksumInfo.md) | The checksum information of the file. When the download is complete, you can retrieve the checksum from the *GET /content/library/item/download-session/{downloadSessionId}/file?file_name* operation to verify the checksum for the downloaded file.  The checksum is always calculated for the downloaded file, but this property won&#39;t be set until the download is complete. | [optional] 
**ErrorMessage** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Error message for a failed preparation when the prepare status is *Content.Library.Item.Downloadsession.File.PrepareStatus.ERROR*.  This property won&#39;t be set unless there was an error with the file transfer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

