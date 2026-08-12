# Vcenter.ViJson.OpenApi.Model.HostIpConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dhcp** | **bool** | The flag to indicate whether or not DHCP (dynamic host control protocol) is enabled.  If this property is set to true, the ipAddress and the subnetMask strings cannot be set explicitly.  | 
**IpAddress** | **string** | The IP address currently used by the network adapter.  All IP addresses are specified using IPv4 dot notation. For example, \&quot;192.168.0.1\&quot;. Subnet addresses and netmasks are specified using the same notation.  **Note**: When DHCP is enabled, this property reflects the current IP configuration and cannot be set. When DHCP is not enabled, this property can be set explicitly.  | [optional] 
**SubnetMask** | **string** | The subnet mask.  **Note**: When DHCP is not enabled, this property can be set explicitly. When DHCP is enabled, this property reflects the current IP configuration and cannot be set.  | [optional] 
**IpV6Config** | [**HostIpConfigIpV6AddressConfiguration**](HostIpConfigIpV6AddressConfiguration.md) | The ipv6 configuration  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

