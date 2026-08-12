# Vcenter.Automation.OpenApi.Model.ContentLibraryItemTransferEndpoint
The Content.Library.Item.TransferEndpoint schema encapsulates a URI along with extra information about it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Transfer endpoint URI. The supported URI schemes are: &#x60;http&#x60;, &#x60;https&#x60;, and &#x60;ds&#x60;.    An endpoint URI with the &#x60;ds&#x60; scheme specifies the location of the file on the datastore. The format of the datastore URI is:     - ds:///vmfs/volumes/uuid/path      When the transfer endpoint is a datastore location, the server can import the file directly from the storage backing without the overhead of streaming over HTTP. | 
**SslCertificateThumbprint** | **string** | Thumbprint of the expected SSL certificate for this endpoint. Only used for HTTPS connections. The thumbprint is the SHA-1 hash of the DER encoding of the remote endpoint&#39;s SSL certificate. If set, the remote endpoint&#39;s SSL certificate is only accepted if it matches this thumbprint, and no other certificate validation is performed. The specified sslCertificateThumbprint will not be checked for SSL certificate validation if {TransferEndpoint#sslCertificate} is also set.  If missing or &#x60;null&#x60;, standard certificate validation is performed. | [optional] 
**SslCertificate** | **string** | PEM encoded SSL Certificate for this endpoint. Only used for HTTPS connections. If set, the remote endpoint&#39;s SSL certificate is only accepted if it matches this, and no other certificate validation is performed.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, standard certificate validation is performed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

