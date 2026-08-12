# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingDnsInfo
The Appliance.Networking.DnsInfo schema contains information about the DNS configuration of a virtual appliance.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | DNS mode.  Possible values:   - &#x60;DHCP&#x60;: The DNS servers addresses are obtained from a DHCP server.   - &#x60;STATIC&#x60;: The DNS servers addresses are specified explicitly.   For more information see: *Appliance.Networking.DnsInfo.DnsMode*.  This property was added in __vSphere API 6.7__. | 
**Hostname** | **string** | Hostname.  This property was added in __vSphere API 6.7__. | 
**Servers** | **List&lt;string&gt;** | Servers.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

