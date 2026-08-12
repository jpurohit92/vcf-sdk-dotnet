# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustedClustersAttestationServicesInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustedClusters.Attestation.Services.Info schema contains all the stored information about a registered Attestation Service instance that is configured for a cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**VcenterTrustedInfrastructureNetworkAddress**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s address.  This property was added in __vSphere API 7.0.0.0__. | 
**TrustedCa** | [**VcenterTrustedInfrastructureX509CertChain**](VcenterTrustedInfrastructureX509CertChain.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s TLS certificate chain.  This property was added in __vSphere API 7.0.0.0__. | 
**Group** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The group determines the Key Provider Service instances can accept reports issued by this Attestation Service instance.  This property was added in __vSphere API 7.0.0.0__. | 
**TrustAuthorityCluster** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The cluster specifies the Trust Authority Cluster this Attestation Service belongs to.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

