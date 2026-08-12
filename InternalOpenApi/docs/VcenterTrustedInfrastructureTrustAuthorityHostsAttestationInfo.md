# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityHostsAttestationInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityHosts.Attestation.Info schema contains all the stored information about a Attestation Service.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The trusted ESX on which the service runs.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**Address** | [**VcenterTrustedInfrastructureNetworkAddress**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s address.  This property was added in __vSphere API 7.0.0.0__. | 
**Group** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The group ID determines which Attestation Service instances this Attestation Service can communicate with.  This property was added in __vSphere API 7.0.0.0__. | 
**Cluster** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The opaque string identifier of the cluster in which the Attestation Service is part of.  This property was added in __vSphere API 7.0.0.0__. | 
**TrustedCa** | [**VcenterTrustedInfrastructureX509CertChain**](VcenterTrustedInfrastructureX509CertChain.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service&#39;s TLS certificate chain.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

