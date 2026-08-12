# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersConsumerPrincipalsFilterSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.ConsumerPrincipals.FilterSpec schema contains data which identifies a connection profile on the trusted vCenter.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The unique identifier of a connection profile.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no filtration will be performed by ID.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.authentication.clientprofile&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.authentication.clientprofile&#x60;. | [optional] 
**Principals** | [**List&lt;VcenterTrustedInfrastructureStsPrincipal&gt;**](VcenterTrustedInfrastructureStsPrincipal.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The principal used by the vCenter to retrieve tokens.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no filtration will be performed by principals. | [optional] 
**Issuer** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service which created and signed the security token.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no filtration will be performed by issuer.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.authentication.trust.security-token-issuer&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.authentication.trust.security-token-issuer&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

