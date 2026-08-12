# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingInterfacesIpv6Info
The Appliance.Networking.Interfaces.Ipv6.Info schema provides the structure that defines an existing IPv6 configuration on a particular interface. This structure is read only.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dhcp** | **bool** | DHCP is on.  This property was added in __vSphere API 6.7__. | 
**Autoconf** | **bool** | Stateless Address Autoconfiguration (SLAAC) is on.  This property was added in __vSphere API 6.7__. | 
**Addresses** | [**List&lt;ApplianceNetworkingInterfacesIpv6AddressInfo&gt;**](ApplianceNetworkingInterfacesIpv6AddressInfo.md) | List of addresses with their origins and statuses.  This property was added in __vSphere API 6.7__. | 
**DefaultGateway** | **string** | The default gateway for static IP address assignment. This configures the global IPv6 default gateway on the appliance with the specified gateway address and interface. This gateway replaces the existing default gateway configured on the appliance. However, if the gateway address is link-local, then it is added for that interface. This does not support configuration of multiple global default gateways through different interfaces.  This property was added in __vSphere API 6.7__. | 
**Configurable** | **bool** | Is NIC configurable or not.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

