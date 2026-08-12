# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersConsumerPrincipalsSummary
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.ConsumerPrincipals.Summary schema contains a summary of the information necessary to establish trust between a workload vCenter and a Trust Authority Host.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The unique identifier of a connection profile.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.authentication.clientprofile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.authentication.clientprofile&#x60;. | 
**Principal** | [**VcenterTrustedInfrastructureStsPrincipal**](VcenterTrustedInfrastructureStsPrincipal.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The principal used by the vCenter to retrieve tokens. Currently this is the vCenter solution user.  This property was added in __vSphere API 7.0.0.0__. | 
**IssuerAlias** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  A user-friendly alias of the service which created and signed the security token.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.authentication.trust.security-token-issuer&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.authentication.trust.security-token-issuer&#x60;. | 
**Issuer** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service which created and signed the security token.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

