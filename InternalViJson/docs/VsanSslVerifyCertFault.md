# Vcenter.ViJson.OpenApi.Model.VsanSslVerifyCertFault

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelfSigned** | **bool** | Whether the host&#39;s certificate was self signed  | 
**Thumbprint** | **string** | The thumbprint of the host&#39;s certificate.  This field is optional since vSphere 8.0u2.  | [optional] 
**Certificate** | **string** | The certificate of the host Note: *SSLVerifyFault.thumbprint* and *SSLVerifyFault.certificate* parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Cert** | **string** | The remote host&#39;s single x509 certificate encoded in PEM format.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

