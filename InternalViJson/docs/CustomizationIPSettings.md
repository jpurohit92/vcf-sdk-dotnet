# Vcenter.ViJson.OpenApi.Model.CustomizationIPSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ip** | [**CustomizationIpGenerator**](CustomizationIpGenerator.md) | Specification to obtain a unique IP address for this virtual network adapter.  | 
**SubnetMask** | **string** | Subnet mask for this virtual network adapter.  | [optional] 
**Gateway** | **List&lt;string&gt;** | For a virtual network adapter with a static IP address, this data object type contains a list of gateways, in order of preference.  | [optional] 
**IpV6Spec** | [**CustomizationIPSettingsIpV6AddressSpec**](CustomizationIPSettingsIpV6AddressSpec.md) | This contains the IpGenerator, subnet mask and gateway info for all the ipv6 addresses associated with the virtual network adapter.  | [optional] 
**DnsServerList** | **List&lt;string&gt;** | A list of server IP addresses to use for DNS lookup in a Windows guest operating system.  In Windows, these settings are adapter-specific, whereas in Linux, they are global. As a result, the Linux guest customization process ignores this setting and looks for its DNS servers in the globalIPSettings object.  Specify these servers in order of preference. If this list is not empty, and if a DHCP IpGenerator is used, then these settings override the DHCP settings.  | [optional] 
**DnsDomain** | **string** | A DNS domain suffix such as vmware.com.  | [optional] 
**PrimaryWINS** | **string** | The IP address of the primary WINS server.  This property is ignored for Linux guest operating systems.  | [optional] 
**SecondaryWINS** | **string** | The IP address of the secondary WINS server.  This property is ignored for Linux guest operating systems.  | [optional] 
**NetBIOS** | **CustomizationNetBIOSModeEnum** | NetBIOS setting for Windows.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

