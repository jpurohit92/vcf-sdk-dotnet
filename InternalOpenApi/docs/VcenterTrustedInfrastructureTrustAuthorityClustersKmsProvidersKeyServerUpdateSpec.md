# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerUpdateSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KeyServerUpdateSpec schema contains properties that describe new configuration for an existing key server.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Type of the key server.     Possible values:   - &#x60;KMIP&#x60;: Key Management Interoperability Protocol (KMIP) based key management server.   For more information see: *Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KeyServerUpdateSpec.Type*.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, key server type and configuration information will remain unchanged. In this case all key server configuration information fields (e.g KMIP) should be unset. | [optional] 
**Description** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Description of the key server.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, description will remain unchanged. | [optional] 
**ProxyServer** | [**VcenterTrustedInfrastructureNetworkAddress**](VcenterTrustedInfrastructureNetworkAddress.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Proxy server configuration.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, proxy server configuration will remain unchanged. | [optional] 
**ConnectionTimeout** | **long** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Connection timeout in seconds.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, connection timeout will remain unchanged. | [optional] 
**KmipServer** | [**VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerUpdateSpec**](VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerUpdateSpec.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Configuration information for KMIP based key server.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, kmip server configuration will remain unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

