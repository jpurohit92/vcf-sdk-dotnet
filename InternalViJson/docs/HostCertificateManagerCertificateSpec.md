# Vcenter.ViJson.OpenApi.Model.HostCertificateManagerCertificateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | The list of supported values can be found in *HostCertificateManagerCertificateKind_enum*  | 
**SubjectAlternativeNames** | **List&lt;string&gt;** | List of subject alternative names to be included in the certificate.  May contain both DNS names and IP addresses. If unset, the certificate will contain only its CN as a SAN.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**CryptoAlgorithm** | **string** | Algorithm and key size used to generate the private key.  The list of supported values can be found in *HostCertificateManagerCryptoAlgorithm_enum* If unset, the RSA algorithm will be used with the key size set to the system&#39;s default value.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

