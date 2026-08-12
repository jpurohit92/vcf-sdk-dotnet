# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersCurrentPeerCertificatesSummary
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.CurrentPeerCertificates.Summary schema contains a summary of the current key server certificates.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerName** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Name of the server.  This property was added in __vSphere API 7.0.0.0__. | 
**Certificate** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Server certificate.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the certificate cannot be retrieved from the remote system, and *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.CurrentPeerCertificates.Summary.trusted* is undefined. See *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.CurrentPeerCertificates.Summary.error_messages* for details. | [optional] 
**ErrorMessages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Server certificate retrieval errors.    Specifies error details when retrieving the remote server certificate fails. This list will be empty when *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.CurrentPeerCertificates.Summary.certificate* is set.  This property was added in __vSphere API 7.0.0.0__. | 
**Trusted** | **bool** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  whether server certificate is already trusted .  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

