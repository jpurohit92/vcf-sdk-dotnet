# Vcenter.ViJson.OpenApi.Model.HttpNfcLeaseSourceFile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetDeviceId** | **string** | Target device id that will be used to store remote file.  Uniquely identifies host, vm and device. Given by this lease in *HttpNfcLeaseDeviceUrl.importKey*.  | 
**Url** | **string** | Full url of the source file, for example https://server/path/disk-1.vmdk.  Or url to OVA, in that case *HttpNfcLeaseSourceFile.memberName* should be specified.  | 
**MemberName** | **string** | Used only when OVA is specified in *HttpNfcLeaseSourceFile.url*.  Should contain file name to extract from OVA.  | [optional] 
**Create** | **bool** | True if PUT should be used for upload, otherwise POST.  Same as *OvfFileItem.create*  | 
**SslThumbprint** | **string** | Esx has no CA database for checking arbitrary certificates.  Client should verify the server certificate and provide certificate thumbprint here.  | [optional] 
**SslCertificate** | **string** | PEM encoded SSL Certificate of the source server.  Note: *HttpNfcLeaseSourceFile.sslThumbprint* and *HttpNfcLeaseSourceFile.sslCertificate* parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**HttpHeaders** | [**List&lt;KeyValue&gt;**](KeyValue.md) | For the case when remote server requires authentication or any other type of custom HTTP headers be provided with the request.  | [optional] 
**Size** | **long** | Size of the file, if known.  Otherwise it will be determined by a HEAD request. Not used for OVA members.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

