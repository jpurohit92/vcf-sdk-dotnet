# Vcenter.ViJson.OpenApi.Model.IpPoolIpPoolConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubnetAddress** | **string** | Address of the subnet.  For example: - IPv4: 192.168.5.0 - IPv6: 2001:0db8:85a3::  | [optional] 
**Netmask** | **string** | Netmask  For example: - IPv4: 255.255.255.0 - IPv6: ffff:ffff:ffff::  | [optional] 
**Gateway** | **string** | Gateway.  This can be an empty string - if no gateway is configured.  Examples: - IPv4: 192.168.5.1 - IPv6: 2001:0db8:85a3::1  | [optional] 
**Range** | **string** | IP range.  This is specified as a set of ranges separated with commas. One range is given by a start address, a hash (#), and the length of the range.  For example: - 192.0.2.235 # 20 is the IPv4 range from 192.0.2.235 to 192.0.2.254 - 2001::7334 # 20 is the IPv6 range from 2001::7334 to 2001::7347  | [optional] 
**Dns** | **List&lt;string&gt;** | DNS servers  For example: - IPv4: \\[\&quot;10.20.0.1\&quot;, \&quot;10.20.0.2\&quot;\\] - IPv6: \\[\&quot;2001:0db8:85a3::0370:7334\&quot;, \&quot;2001:0db8:85a3::0370:7335\&quot;\\]    If an empty list is passed, the existing value remains unchanged. To clear this list, pass an array containing the empty string as it&#39;s only element.  | [optional] 
**DhcpServerAvailable** | **bool** | Whether a DHCP server is available on this network.  | [optional] 
**IpPoolEnabled** | **bool** | IP addresses can only be allocated from the range if the IP pool is enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

