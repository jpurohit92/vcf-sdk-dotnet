# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersAttestationTpm2EndorsementKeysSummary
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.EndorsementKeys.Summary schema contains information that summarizes a TPM endorsement key.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A unique name for the TPM endorsement key.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.trust_authority_clusters.attestation.tpm2.EndorsementKey&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.trust_authority_clusters.attestation.tpm2.EndorsementKey&#x60;. | 
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A health indicator which indicates whether each host in the cluster has the same endorsement key.  Possible values:   - &#x60;NONE&#x60;: No status available.   - &#x60;OK&#x60;: Each host in the cluster is in consistent state with the rest hosts in the cluster.   - &#x60;WARNING&#x60;: Attestation is functioning, however there is an issue that requires attention.   - &#x60;ERROR&#x60;: Not all hosts in the cluster are in consistent state.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Attestation.Tpm2.EndorsementKeys.Health*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

