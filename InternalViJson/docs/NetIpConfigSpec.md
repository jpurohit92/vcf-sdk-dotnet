# Vcenter.ViJson.OpenApi.Model.NetIpConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | [**List&lt;NetIpConfigSpecIpAddressSpec&gt;**](NetIpConfigSpecIpAddressSpec.md) | A set of manual (static) IP addresses to be configured on a given interface.  | [optional] 
**Dhcp** | [**NetDhcpConfigSpec**](NetDhcpConfigSpec.md) | Configure client side DHCP for a given interface.  | [optional] 
**AutoConfigurationEnabled** | **bool** | Enable or disable ICMPv6 router solictitation requests from a given interface to acquire an IPv6 address and default gateway route from zero, one or more routers on the connected network.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

