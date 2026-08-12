# Vcenter.Automation.OpenApi.Model.VcenterGuestWindowsNetworkAdapterSettings
The Vcenter.Guest.WindowsNetworkAdapterSettings schema specifies Windows specific Network settings for a virtual network adapter.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsServers** | **List&lt;string&gt;** | A list of server IP addresses to use for DNS lookup in a Windows guest operating system.    These servers should be specified in the order of preference. If this list is not empty, and if a DHCP IP address is used, then these settings override the DHCP settings.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no DNS servers are set. | [optional] 
**DnsDomain** | **string** | A DNS domain suffix such as vmware.com.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no DNS domain is set. | [optional] 
**WinsServers** | **List&lt;string&gt;** | List of WINS Servers to set for the Windows guest operating system. A Maximum of two IP addresses can be specified in this list. The first IP address will be set as the primary WINS server. The second IP address will be set as the secondary WINS server.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no WINS Servers are set. | [optional] 
**NetBiosMode** | **string** | NetBIOS setting for Windows.  Possible values:   - &#x60;USE_DHCP&#x60;: DHCP server decides whether or not to use NetBIOS.   - &#x60;ENABLE&#x60;: Always use NetBIOS.   - &#x60;DISABLE&#x60;: Never use NetBIOS.   For more information see: *Vcenter.Guest.WindowsNetworkAdapterSettings.NetBIOSMode*.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, existing NetBIOS mode will be retained. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

