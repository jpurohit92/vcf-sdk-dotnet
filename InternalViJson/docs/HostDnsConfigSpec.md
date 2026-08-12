# Vcenter.ViJson.OpenApi.Model.HostDnsConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dhcp** | **bool** | The flag to indicate whether or not DHCP (dynamic host control protocol) is used to determine DNS configuration automatically.  | 
**VirtualNicDevice** | **string** | If DHCP is enabled, the DHCP DNS of the vmkernel nic will override the system&#39;s DNS.  This field applies to both IPv4 and IPv6 DNS settings if *ipv6VirtualNicDevice* is unset, otherwise it is applicable only for IPv4 setting. This field is ignored if DHCP is disabled by the *dhcp* property.  | [optional] 
**Ipv6VirtualNicDevice** | **string** | If DHCP is enabled, the IPv6 DHCP DNS of the vmkernel nic will override the system&#39;s IPv6 DNS.  This field is ignored if DHCP is disabled by the *dhcp* property.  | [optional] 
**HostName** | **string** | The host name portion of DNS name.  For example, \&quot;esx01\&quot;.  **Note**: When DHCP is not enabled, the property can be set explicitly. When DHCP is enabled, the property reflects the current DNS configuration, but cannot be set. The hostName can&#39;t have character &#39;.&#39; in it when set explicitly.  | 
**DomainName** | **string** | The domain name portion of the DNS name.  For example, \&quot;vmware.com\&quot;.  **Note**: When DHCP is not enabled, the property can be set explicitly. When DHCP is enabled, the property reflects the current DNS configuration, but cannot be set.  | 
**Address** | **List&lt;string&gt;** | The IP addresses of the DNS servers, placed in order of preference.  **Note**: When DHCP is not enabled, the property can be set explicitly. When DHCP is enabled, the property reflects the current DNS configuration, but cannot be set.  | [optional] 
**SearchDomain** | **List&lt;string&gt;** | The domain in which to search for hosts, placed in order of preference.  **Note**: When DHCP is not enabled, the property can be set explicitly. When DHCP is enabled, the property reflects the current DNS configuration, but cannot be set.  | [optional] 
**VirtualNicConnection** | [**HostVirtualNicConnection**](HostVirtualNicConnection.md) | Choose a Virtual nic based on what it is connected to.  | [optional] 
**VirtualNicConnectionV6** | [**HostVirtualNicConnection**](HostVirtualNicConnection.md) | Choose an IPv6 Virtual nic based on what it is connected to.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

