# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingInterfacesInterfaceInfo
Appliance.Networking.Interfaces.InterfaceInfo schema Structure that defines properties and status of a network interface.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Interface name, for example, \&quot;nic0\&quot;, \&quot;nic1\&quot;. | 
**Status** | **string** | Interface status.  Possible values:   - &#x60;down&#x60;: The interface is down.   - &#x60;up&#x60;: The interface is up.   For more information see: *Appliance.Networking.Interfaces.InterfaceStatus*. | 
**Mac** | **string** | MAC address. For example 00:0C:29:94:BB:5A. | 
**Ipv4** | [**ApplianceNetworkingInterfacesIpv4Info**](ApplianceNetworkingInterfacesIpv4Info.md) | IPv4 Address information.  This property was added in __vSphere API 6.7__.  ipv4 This property will be missing or &#x60;null&#x60; if IPv4 is not enabled. | [optional] 
**Ipv6** | [**ApplianceNetworkingInterfacesIpv6Info**](ApplianceNetworkingInterfacesIpv6Info.md) | IPv6 Address information.  This property was added in __vSphere API 6.7__.  ipv6 This property will be missing or &#x60;null&#x60; if IPv6 is not enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

