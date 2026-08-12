# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersAttestationTpm2CaCertificatesInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.CaCertificates.Info schema contains information that describes a TPM CA certificate.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertChain** | [**VcenterTrustedInfrastructureX509CertChain**](VcenterTrustedInfrastructureX509CertChain.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The CA certificate chain.  This property was added in __vSphere API 7.0.0.0__. | 
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A health indicator which indicates whether each host in the cluster has the same CA certs.  Possible values:   - &#x60;NONE&#x60;: No status available.   - &#x60;OK&#x60;: Each host in the cluster is in consistent state with the rest hosts in the cluster.   - &#x60;WARNING&#x60;: Attestation is functioning, however there is an issue that requires attention.   - &#x60;ERROR&#x60;: Not all hosts in the cluster are in consistent state.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.CaCertificates.Health*.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Details regarding the health.    When the Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.CaCertificates.Health is not *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.CaCertificates.Health.OK* or *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.CaCertificates.Health.NONE*, this member will provide an actionable description of the issues present.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

