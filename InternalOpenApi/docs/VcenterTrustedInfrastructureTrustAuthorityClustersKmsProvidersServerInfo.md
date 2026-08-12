# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersServerInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.ServerInfo schema contains properties that describe the status of a key server.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Health** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The connection status health of the server.  Possible values:   - &#x60;NONE&#x60;: No status available.   - &#x60;OK&#x60;: Health is normal.   - &#x60;WARNING&#x60;: Health is normal, however there is an issue that requires attention.   - &#x60;ERROR&#x60;: Not healthy.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.Health*.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Details regarding the health of the server connection.    When the service Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.Health is not *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.Health.OK*, this property will provide an actionable description of the issue.  This property was added in __vSphere API 7.0.0.0__. | 
**ClientTrustServer** | **bool** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Whether this client trusts the server.  This property was added in __vSphere API 7.0.0.0__. | 
**ServerTrustClient** | **bool** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Whether the server trusts this client.  This property was added in __vSphere API 7.0.0.0__. | 
**Name** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Name of the server.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

