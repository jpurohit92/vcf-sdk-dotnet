# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerInfo
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KeyServerInfo schema contains properties that describe the current configuration of a key server.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Type of the key server.  Possible values:   - &#x60;KMIP&#x60;: Key Management Interoperability Protocol (KMIP) based key management server.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KeyServerInfo.Type*.  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Description of the key server.  This property was added in __vSphere API 7.0.0.0__. | 
**ProxyServer** | [**VcenterTrustedInfrastructureNetworkAddress**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Proxy server configuration.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, proxy server configuration will not be set. | [optional] 
**ConnectionTimeout** | **long** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Connection timeout in seconds.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, connection timeout will be unset. | [optional] 
**KmipServer** | [**VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerInfo**](VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerInfo.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Configuration information for KMIP based key server.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KeyServerInfo.Type.KMIP*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

