# Vcenter.Automation.OpenApi.Model.ContentLibraryItemDownloadsessionFilePrepareRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** |  Name of the file requested for download. | 
**EndpointType** | **string** |  Endpoint type request, one of EndpointType. This will determine the type of the *Content.Library.Item.Downloadsession.File.Info.download_endpoint* that is generated when the file is prepared. The *Content.Library.Item.Downloadsession.File.EndpointType.DIRECT* is only available to users who have the ContentLibrary.ReadStorage privilege.  Possible values:   - &#x60;HTTPS&#x60;: An https download endpoint.   - &#x60;DIRECT&#x60;: A direct download endpoint indicating the location of the file on storage. The caller is responsible for retrieving the file from the storage location directly.   For more information see: *Content.Library.Item.Downloadsession.File.EndpointType*.  If not specified the default is *Content.Library.Item.Downloadsession.File.EndpointType.HTTPS*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

