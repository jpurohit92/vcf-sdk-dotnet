# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructurePrincipalInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.Principal.Info schema contains the information about the principal and certificates used by this vCenter to retrieve tokens.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificates** | [**List&lt;VcenterTrustedInfrastructureX509CertChain&gt;**](VcenterTrustedInfrastructureX509CertChain.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The certificates used by the STS to sign tokens for this vCenter.  This property was added in __vSphere API 7.0.0.0__. | 
**Issuer** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The service which created and signed the security token.  This property was added in __vSphere API 7.0.0.0__. | 
**Principal** | [**VcenterTrustedInfrastructureStsPrincipal**](VcenterTrustedInfrastructureStsPrincipal.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The principal used by this vCenter instance to retrieve tokens. Currently this is the vCenter solution user.  This property was added in __vSphere API 7.0.0.0__. | 
**Name** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The user-friednly name of the vCenter.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

