# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerUpdateSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KmipServerUpdateSpec schema contains properties that describe new configuration for KMIP based key server.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | [**List&lt;VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersServer&gt;**](VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersServer.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  List of KMIP compliant key servers.    Key servers must be configured for active-active replication. If the server port is missing or &#x60;null&#x60;, a default value for KMIP&#39;s port will be used.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, server configuration will remain unchanged. | [optional] 
**Username** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Username for authentication.     This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, username will remain unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

