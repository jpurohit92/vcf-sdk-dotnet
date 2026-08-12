# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksServices
Vcenter.NamespaceManagement.Networks.Services schema describes services that assists applications in communicating on a network.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dns** | [**VcenterNamespaceManagementNetworksServiceDNS**](VcenterNamespaceManagementNetworksServiceDNS.md) | *Vcenter.NamespaceManagement.Networks.Services.dns* describes DNS servers and search domains for a given network.  This property was added in __vSphere API 8.0.0.1__.  If unset, no DNS settings will be configured. | [optional] 
**Ntp** | [**VcenterNamespaceManagementNetworksServiceNTP**](VcenterNamespaceManagementNetworksServiceNTP.md) | *Vcenter.NamespaceManagement.Networks.Services.ntp* describes NTP servers running on this network that networked applications can use for synchronizing time.  This property was added in __vSphere API 8.0.0.1__.  If unset, no NTP settings will be configured. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

