# Vcenter.ViJson.OpenApi.Model.NetDnsConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dhcp** | **bool** | The flag to indicate whether or not dynamic host control protocol (DHCP) will be used to set DNS configuration automatically.  See vim.net.DhcpConfigSpec  | [optional] 
**HostName** | **string** | The host name portion of DNS name.  For example, \&quot;esx01\&quot; part of esx01.example.com. The rules for forming a hostname are specified in RFC 1034.  | [optional] 
**DomainName** | **string** | The domain name portion of the DNS name.  This would be the \&quot;example.com\&quot; part of esx01.example.com. The rules for forming a domain name are defined in RFC 1034.  | [optional] 
**IpAddress** | **List&lt;string&gt;** | Unicast IP address(s) of one or more DNS servers in order of use.  IPv4 addresses are specified using dotted decimal notation. For example, \&quot;192.0.2.1\&quot;. IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits. A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of the symbol &#39;::&#39; to represent multiple 16-bit groups of contiguous 0&#39;s only once in an address as described in RFC 2373.  | [optional] 
**SearchDomain** | **List&lt;string&gt;** | The domain in which to search for hosts in order of preference.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

