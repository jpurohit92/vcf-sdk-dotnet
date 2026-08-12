# Vcenter.ViJson.OpenApi.Model.PhysicalNicSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ip** | [**HostIpConfig**](HostIpConfig.md) | The IP configuration on the physical network adapter (applies only to a hosted network adapter).  The data object will be NULL on an ESX Server system.  | [optional] 
**LinkSpeed** | [**PhysicalNicLinkInfo**](PhysicalNicLinkInfo.md) | The link speed and duplexity that this physical network adapter is currently configured to use.  If this property is not set, the physical network adapter autonegotiates its proper settings.  | [optional] 
**EnableEnhancedNetworkingStack** | **bool** | If set the flag indicates if the physical network adapter is configured for Enhanced Networking Stack  | [optional] 
**EnsInterruptEnabled** | **bool** | If set the flag indicates if the physical network adapter is configured for Enhanced Networking Stack interrupt mode  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

