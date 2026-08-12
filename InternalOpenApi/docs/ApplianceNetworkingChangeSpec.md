# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingChangeSpec
This schema was added in __vSphere API 6.7.3__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | New hostname to assign to the management network of vCenter appliance  This property was added in __vSphere API 6.7.3__. | 
**SsoUser** | **string** | vCenter Server SSO administrator username  This property was added in __vSphere API 6.7.3__. | 
**SsoPassword** | **string** | vCenter Server SSO administrator Password  This property was added in __vSphere API 6.7.3__. | 
**Dns** | [**ApplianceNetworkingDnsServersDNSServerConfig**](ApplianceNetworkingDnsServersDNSServerConfig.md) | DNS Configuration to set for the machine  This property was added in __vSphere API 6.7.3__.  If missing or &#x60;null&#x60; DNS settings will not be changed | [optional] 
**Ipv4** | [**ApplianceNetworkingInterfacesIpv4Config**](ApplianceNetworkingInterfacesIpv4Config.md) | IPv4 Configuration to set for the machine  This property was added in __vSphere API 6.7.3__.  If missing or &#x60;null&#x60; IPv4 settings will not be changed | [optional] 
**Ipv6** | [**ApplianceNetworkingInterfacesIpv6Config**](ApplianceNetworkingInterfacesIpv6Config.md) | IPv6 Configuration to set for the machine  This property was added in __vSphere API 6.7.3__.  If missing or &#x60;null&#x60; IPv6 settings will not be changed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

