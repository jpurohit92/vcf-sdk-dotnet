# Vcenter.Automation.OpenApi.Model.VcenterVmGuestDnsConfigInfo
The Vcenter.Vm.Guest.DnsConfigInfo schema describes the configuration of RFC 1034 DNS settings.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddresses** | **List&lt;string&gt;** | The IP addresses of the DNS servers in order of use. IPv4 addresses are specified using dotted decimal notation. For example, \&quot;192.0.2.1\&quot;. IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits. A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of the symbol &#39;::&#39; to represent multiple 16-bit groups of contiguous 0&#39;s only once in an address as described in RFC 2373.  This property was added in __vSphere API 7.0.0.0__. | 
**SearchDomains** | **List&lt;string&gt;** | The domain in which to search for hosts, placed in order of preference. These are the domain name portion of the DNS names.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

