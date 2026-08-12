# Vcenter.Automation.OpenApi.Model.VcenterGuestGlobalDNSSettings
The Vcenter.Guest.GlobalDNSSettings schema specifies a collection of global IP settings in the guest operating system. In Linux, DNS server settings are global. The settings can either be statically set or supplied by a DHCP server.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsSuffixList** | **List&lt;string&gt;** | List of name resolution suffixes for the virtual network adapter. This list applies to both Windows and Linux guest customization. For Linux, this setting is global, whereas in Windows, this setting is listed on a per-adapter basis.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no DNS suffixes are set. | [optional] 
**DnsServers** | **List&lt;string&gt;** | List of DNS servers, for a virtual network adapter with a static IP address. If this list is empty, then the guest operating system is expected to use a DHCP server to get its DNS server settings. These settings configure the virtual machine to use the specified DNS servers. These DNS server settings are listed in the order of preference.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no DNS servers are set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

