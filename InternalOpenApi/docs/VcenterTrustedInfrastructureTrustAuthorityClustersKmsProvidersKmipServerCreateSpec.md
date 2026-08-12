# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerCreateSpec
This schema is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  The Vcenter.TrustedInfrastructure.TrustAuthorityClusters.Kms.Providers.KmipServerCreateSpec schema contains properties that describe Key Management Interoperability Protocol (KMIP) desired key server configuration.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | [**List&lt;VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersServer&gt;**](VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersServer.md) | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  List of Key Management Interoperability Protocol (KMIP) compliant key servers.    Key servers must be configured for active-active replication. If the server port is missing or &#x60;null&#x60;, a default value for KMIP&#39;s port will be used.  This property was added in __vSphere API 7.0.0.0__. | 
**Username** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__ and removed in __vSphere API 9.0.0.0__.  Username for authentication.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no username will be added. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

