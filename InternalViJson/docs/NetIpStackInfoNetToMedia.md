# Vcenter.ViJson.OpenApi.Model.NetIpStackInfoNetToMedia

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | **string** | A Unicast IP address of another system directly reachable w/o routing.  IPv4 address is specified using dotted decimal notation. For example, \&quot;192.0.2.1\&quot;. IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits. A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of the symbol &#39;::&#39; to represent multiple 16-bit groups of contiguous 0&#39;s only once in an address as described in RFC 2373.  | 
**PhysicalAddress** | **string** | The media-dependent of the address or empty string if not yet learned.  For Ethernet interfaces this is a MAC address reported in the format: XX:XX:XX:XX:XX:XX where XX are hexadecimal numbers.  | 
**Device** | **string** | The value will be the name of the interface as reported by the operating system.  | 
**Type** | **string** | The type/state of this entry as reported by the IP stack.  See *NetIpStackInfoEntryType_enum* for values.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

