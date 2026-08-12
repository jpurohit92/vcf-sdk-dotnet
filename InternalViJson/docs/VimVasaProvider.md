# Vcenter.ViJson.OpenApi.Model.VimVasaProvider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Provider UID.  This is populated with namespace prefixed to providerId, which uniquely identifies a VASA Provider. Both namespace and providerId are sourced from Vasa Provider and available within SMS. This field helps in preventing a regeneration of duplicate VASA Provider within vvold when a user attempts to register the same VP using different names or alternative urls.  | [optional] 
**Url** | **string** | VASA Provider URL.  In VirtualHost based MultiVC setup, this is set to default virtual host&#39;s URL.  | 
**Name** | **string** | Name  | [optional] 
**SelfSignedCertificate** | **string** | Self-signed certificate of VASA provider.  In VirtualHost based MultiVC setup, this is set to default virtual host&#39;s self-signed certificate.  | [optional] 
**VhostConfig** | [**VimVasaProviderVirtualHostConfig**](VimVasaProviderVirtualHostConfig.md) | Virtual host configuration for VASA Provider when it supports MultiVC through VirtualHosts.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**VersionId** | **int** | SMS supported VASA provider versionId.  i-e if versionX corresponds to VASA version supported by SMS, then X needs to be set here. versionX corresponds to SMS supported VASA versions are, 1.0-&amp;gt;version1, 1.5-&amp;gt;version2, 2.0-&amp;gt;version3, 3.0-&amp;gt;version4, 3.5-&amp;gt;version5, 4.0-&amp;gt;version6, 5.0-&amp;gt;version7, etc. For example: If SMS is connecting to VASA 5.0, the this field should be set to 7.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

