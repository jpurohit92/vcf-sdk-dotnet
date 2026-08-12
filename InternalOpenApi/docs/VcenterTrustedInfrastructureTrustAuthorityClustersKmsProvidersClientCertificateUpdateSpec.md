# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersClientCertificateUpdateSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.ClientCertificate.UpdateSpec schema contains properties that describe the client certificate update for a Key Provider.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Public certificate used by every host in the cluster.  This property was added in __vSphere API 7.0.0.0__. | 
**PrivateKey** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Private part of the certificate.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the update request is for a public/private client certificate pair, not for a signed CSR. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

