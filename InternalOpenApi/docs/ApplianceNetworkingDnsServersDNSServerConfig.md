# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingDnsServersDNSServerConfig
Appliance.Networking.Dns.Servers.DNSServerConfig schema This structure represents the configuration state used to determine DNS servers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Define how to determine the DNS servers. Leave the servers argument empty if the mode argument is \&quot;DHCP\&quot;. Set the servers argument to a comma-separated list of DNS servers if the mode argument is \&quot;static\&quot;. The DNS server are assigned from the specified list.  Possible values:   - &#x60;dhcp&#x60;: DNS address is automatically assigned by a DHCP server.   - &#x60;is_static&#x60;: DNS address is static.   For more information see: *Appliance.Networking.Dns.Servers.DNSServerMode*. | 
**Servers** | **List&lt;string&gt;** | List of the currently used DNS servers. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

