# Vcenter.ViJson.OpenApi.Model.HostFirewallRulesetIpList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | **List&lt;string&gt;** | The list of ipAddresses.  All IPv4 addresses are specified as strings using dotted decimal format. For example, \&quot;192.0.20.10\&quot;. IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits. A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of symbol &#39;::&#39; to represent multiple 16-bit groups of contiguous 0&#39;s only once in an address as described in RFC 2373.  | [optional] 
**IpNetwork** | [**List&lt;HostFirewallRulesetIpNetwork&gt;**](HostFirewallRulesetIpNetwork.md) | The list of networks  | [optional] 
**AllIp** | **bool** | Flag indicating whether the ruleset works for all ip addresses.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

