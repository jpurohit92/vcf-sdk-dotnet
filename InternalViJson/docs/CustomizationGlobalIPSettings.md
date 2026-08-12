# Vcenter.ViJson.OpenApi.Model.CustomizationGlobalIPSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsSuffixList** | **List&lt;string&gt;** | List of name resolution suffixes for the virtual network adapter.  This list applies to both Windows and Linux guest customization. For Linux, this setting is global, whereas in Windows, this setting is listed on a per-adapter basis, even though the setting is global in Windows.  | [optional] 
**DnsServerList** | **List&lt;string&gt;** | List of DNS servers, for a virtual network adapter with a static IP address.  If this list is empty, then the guest operating system is expected to use a DHCP server to get its DNS server settings. These settings configure the virtual machine to use the specified DNS servers. These DNS server settings are listed in order of preference.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

