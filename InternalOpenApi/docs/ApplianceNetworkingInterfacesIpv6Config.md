# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingInterfacesIpv6Config
The Appliance.Networking.Interfaces.Ipv6.Config schema provides the structure that you can use to configure IPv6 on a particular interface. Addresses can be assigned by DHCP, SLAAC or STATIC, as IPv6 permits multiple addresses per interface.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dhcp** | **bool** | An address will be assigned by a DHCP server.  This property was added in __vSphere API 6.7__. | 
**Autoconf** | **bool** | An address will be assigned by Stateless Address Autoconfiguration (SLAAC).  This property was added in __vSphere API 6.7__. | 
**Addresses** | [**List&lt;ApplianceNetworkingInterfacesIpv6Address&gt;**](ApplianceNetworkingInterfacesIpv6Address.md) | The list of addresses to be statically assigned.  This property was added in __vSphere API 6.7__. | 
**DefaultGateway** | **string** | The default gateway for static IP address assignment. This configures the global IPv6 default gateway on the appliance with the specified gateway address and interface. This gateway replaces the existing default gateway configured on the appliance. However, if the gateway address is link-local, then it is added for that interface. This does not support configuration of multiple global default gateways through different interfaces.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

