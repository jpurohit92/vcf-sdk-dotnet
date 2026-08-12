# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaIPProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mac** | **string** | The MAC address.  | [optional] 
**Address** | **string** | The current IPv4 address.  | [optional] 
**DhcpConfigurationEnabled** | **bool** | True if the host bus adapter fetches its IP using DHCP.  | 
**SubnetMask** | **string** | The current IPv4 subnet mask.  | [optional] 
**DefaultGateway** | **string** | The current IPv4 gateway.  | [optional] 
**PrimaryDnsServerAddress** | **string** | The current primary DNS address.  | [optional] 
**AlternateDnsServerAddress** | **string** | The current secondary DNS address.  | [optional] 
**Ipv6Address** | **string** | Deprecated since vSphere API 5.5 use { @link IPProperties#ipv6properties }.  The current IPv6 address.  | [optional] 
**Ipv6SubnetMask** | **string** | Deprecated since vSphere API 5.5 use { @link IPProperties#ipv6properties }.  The current IPv6 subnet mask.  | [optional] 
**Ipv6DefaultGateway** | **string** | Deprecated since vSphere API 5.5 use { @link IPProperties#ipv6properties }.  The current IPv6 default gateway.  | [optional] 
**ArpRedirectEnabled** | **bool** | True if ARP Redirect is enabled  | [optional] 
**Mtu** | **int** | True if the host bus adapter supports setting its MTU, (for Jumbo Frames, etc) Setting enableJumboFrames and not a numeric mtu value implies autoselection of appropriate MTU value for Jumbo Frames.  | [optional] 
**JumboFramesEnabled** | **bool** |  | [optional] 
**Ipv4Enabled** | **bool** | True if IPv4 is enabled.  Unset value will keep existing IPv4 enabled state as is.  | [optional] 
**Ipv6Enabled** | **bool** | True if IPv6 is enabled.  Unset value will keep existing IPv6 enabled state as is.  | [optional] 
**Ipv6properties** | [**HostInternetScsiHbaIPv6Properties**](HostInternetScsiHbaIPv6Properties.md) | IPv6 properties.  It is set only if { @link #ipv6Enabled } is true.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

