# Vcenter.ViJson.OpenApi.Model.NetIpRouteConfigSpecIpRouteSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | IP Address of the destination IP network.  IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits. A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of symbol &#39;::&#39; to represent multiple 16-bit groups of contiguous 0&#39;s only once in an address as described in RFC 2373. To Specify a default network use the value: 0 with prefixLength 0.  | 
**PrefixLength** | **int** | The prefix length.  For IPv4 the value range is 0-31. For IPv6 prefixLength is a decimal value range 0-127. The property represents the number of contiguous, higher-order bits of the address that make up the network portion of the IP address.  | 
**Gateway** | [**NetIpRouteConfigSpecGatewaySpec**](NetIpRouteConfigSpecGatewaySpec.md) | Where to send the packets for this route.  | 
**Operation** | **string** | Requires one of the values from *HostConfigChangeOperation_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

