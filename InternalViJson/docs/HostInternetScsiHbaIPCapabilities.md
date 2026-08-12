# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaIPCapabilities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressSettable** | **bool** | True if the host bus adapter supports setting its IPv4 address.  | 
**IpConfigurationMethodSettable** | **bool** | True if the host bus adapter supports DHCPv4.  | 
**SubnetMaskSettable** | **bool** | True if the host bus adapter supports setting its IPv4 subnet mask.  | 
**DefaultGatewaySettable** | **bool** | True if the host bus adapter supports setting its IPv4 gateway.  | 
**PrimaryDnsServerAddressSettable** | **bool** | True if the host bus adapter supports setting its primary DNS.  | 
**AlternateDnsServerAddressSettable** | **bool** | True if the host bus adapter supports setting its secondary DNS.  | 
**Ipv6Supported** | **bool** | True if the host bus adapter supports the use of IPv6 addresses  | [optional] 
**ArpRedirectSettable** | **bool** | True if the host bus adapter supports setting its ARP Redirect value  | [optional] 
**MtuSettable** | **bool** | True if the host bus adapter supports setting its MTU, (for Jumbo Frames, etc)  | [optional] 
**HostNameAsTargetAddress** | **bool** | True if the discovery and static targets can be configured with a host name as opposed to an IP address.  | [optional] 
**NameAliasSettable** | **bool** | True if the host bus adapter supports setting its name and alias  | [optional] 
**Ipv4EnableSettable** | **bool** | True if IPv4 addressing can be enabled or disabled on the host bus adapter.  | [optional] 
**Ipv6EnableSettable** | **bool** | True if IPv6 addressing can be enabled or disabled on the host bus adapter.  | [optional] 
**Ipv6PrefixLengthSettable** | **bool** | True if the Host bus adapter supports setting IPv6 Prefix Length.  | [optional] 
**Ipv6PrefixLength** | **int** | Provides the value that user should be using if host bus adapter does not support changing of prefix length.  | [optional] 
**Ipv6DhcpConfigurationSettable** | **bool** | True if the Host bus adapter supports DHCPv6 configuration.  | [optional] 
**Ipv6LinkLocalAutoConfigurationSettable** | **bool** | True if the Host bus adapter supports setting configuration of its IPv6 link local address User can specify link local static address if link local auto configuration is set to false.  link local address usually starts with fe80: and has prefix 64.  | [optional] 
**Ipv6RouterAdvertisementConfigurationSettable** | **bool** | True if the Host bus adapter supports router advertisement configuration method.  Note: Currently Qlogic adapter does not support plumbing of any user specified static address if router advertisement method is enabled.  | [optional] 
**Ipv6DefaultGatewaySettable** | **bool** | True if the Host bus adapter supports setting its IPv6 default gateway.  | [optional] 
**Ipv6MaxStaticAddressesSupported** | **int** | The maximum number of supported IPv6 static addresses on the host bus adapter that user can set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

