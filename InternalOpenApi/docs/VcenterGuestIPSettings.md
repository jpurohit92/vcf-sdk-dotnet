# Vcenter.Automation.OpenApi.Model.VcenterGuestIPSettings
The Vcenter.Guest.IPSettings schema specifies the IP settings for a virtual network adapter.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ipv4** | [**VcenterGuestIpv4**](VcenterGuestIpv4.md) | Specification to configure IPv4 address, subnet mask and gateway info for this virtual network adapter.  This property was added in __vSphere API 7.0.0.0__.  This property is currently required. If missing or &#x60;null&#x60;, the specification creation operation will fail. | [optional] 
**Ipv6** | [**VcenterGuestIpv6**](VcenterGuestIpv6.md) | Specification to configure IPv6 address, subnet mask and gateway info for this virtual network adapter.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no IPv6 addresses are set. | [optional] 
**Windows** | [**VcenterGuestWindowsNetworkAdapterSettings**](VcenterGuestWindowsNetworkAdapterSettings.md) | Windows settings to be configured for this specific virtual Network adapter. This is valid only for Windows guest operating systems.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no specific Windows settings are set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

