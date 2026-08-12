# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaIPv6Properties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IscsiIpv6Address** | [**List&lt;HostInternetScsiHbaIscsiIpv6Address&gt;**](HostInternetScsiHbaIscsiIpv6Address.md) | There can be multiple IPv6 addressed plumbed onto the Host Bus Adapter.  | [optional] 
**Ipv6DhcpConfigurationEnabled** | **bool** | True if DHCPv6 is enabled on the host bus adapter.  User can keep this field unset while changing other IPv6 properties without altering current DHCP configuration.  | [optional] 
**Ipv6LinkLocalAutoConfigurationEnabled** | **bool** | True if auto configuration of link local address is enabled on the host bus adapter.  User can keep this field unset while changing other IPv6 properties without altering current link local auto configuration.  | [optional] 
**Ipv6RouterAdvertisementConfigurationEnabled** | **bool** | True if the router advertisement configuration is enabled on the host bus adapter.  User can keep this field unset while changing other IPv6 properties without altering current router advertisement configuration.  | [optional] 
**Ipv6DefaultGateway** | **string** | The current IPv6 default gateway.  User can keep this field unset while changing other IPv6 properties without altering current default gateway configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

