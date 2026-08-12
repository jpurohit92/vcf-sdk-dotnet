# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersAttestationTpm2CaCertificatesCreateSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.CaCertificates.CreateSpec schema contains information that describes a TPM CA certificate.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A unique name for the TPM CA certificate.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.trust_authority_clusters.attestation.tpm2.CaCertificate&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.trust_authority_clusters.attestation.tpm2.CaCertificate&#x60;. | 
**CertChain** | [**VcenterTrustedInfrastructureX509CertChain**](VcenterTrustedInfrastructureX509CertChain.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The CA certificate chain.    Certificates may either be added one at a time, or as a chain. Adding the certificates as a chain allows the group to be managed as a whole. For example, an entire chain can be deleted in one *DELETE /vcenter/trusted-infrastructure/trust-authority-clusters/{cluster}/attestation/tpm2/ca-certificates/{name}* operation.    When certificates are added one at a time, the order must be root first, followed by any intermediates. The intermediates certificates must also be ordered in the direction from root to leaf.    Similarly, when added as a chain the list must be ordered in the direction from root to leaf.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; creation will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

