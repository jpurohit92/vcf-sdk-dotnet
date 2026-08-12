# Vcenter.ViJson.OpenApi.Model.HostIpConfigIpV6AddressConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpV6Address** | [**List&lt;HostIpConfigIpV6Address&gt;**](HostIpConfigIpV6Address.md) | Ipv6 addresses configured on the interface.  The global addresses can be configured through DHCP, stateless or manual configuration. Link local addresses can be only configured with the origin set to *other*.  | [optional] 
**AutoConfigurationEnabled** | **bool** | Specify if IPv6 address and routing information information be enabled or not as per RFC 2462.  | [optional] 
**DhcpV6Enabled** | **bool** | The flag to indicate whether or not DHCP (dynamic host control protocol) is enabled to obtain an ipV6 address.  If this property is set to true, an ipV6 address is configured through dhcpV6.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

