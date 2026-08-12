# Vcenter.ViJson.OpenApi.Model.HostCertificateManagerCertificateInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | Certificate kind, if unset the certificate is Machine certificate The list of supported values can be found in *HostCertificateManagerCertificateKind_enum*  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**Issuer** | **string** | The issuer of the certificate.  | [optional] 
**NotBefore** | **DateTime** | The validity of the certificate.  | [optional] 
**NotAfter** | **DateTime** |  | [optional] 
**Subject** | **string** | The subject of the certificate.  | [optional] 
**Status** | **string** | The status of the certificate in vCenter Server.  The possible values for status are as described in *HostCertificateManagerCertificateInfoCertificateStatus_enum*. If queried directly from an ESX host, the property is set to *unknown*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

