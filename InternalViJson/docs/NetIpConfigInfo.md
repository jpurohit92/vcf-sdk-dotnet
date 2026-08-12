# Vcenter.ViJson.OpenApi.Model.NetIpConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | [**List&lt;NetIpConfigInfoIpAddress&gt;**](NetIpConfigInfoIpAddress.md) | Zero, one or more manual (static) assigned IP addresses to be configured on a given interface.  | [optional] 
**Dhcp** | [**NetDhcpConfigInfo**](NetDhcpConfigInfo.md) | Client side DHCP for a given interface.  | [optional] 
**AutoConfigurationEnabled** | **bool** | Enable or disable ICMPv6 router solicitation requests from a given interface to acquire an IPv6 address and default gateway route from zero, one or more routers on the connected network.  If not set then ICMPv6 is not available on this system, See vim.host.Network.Capabilities  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

