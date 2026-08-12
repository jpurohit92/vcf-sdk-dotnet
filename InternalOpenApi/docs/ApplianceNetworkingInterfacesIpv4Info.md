# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingInterfacesIpv4Info
The Appliance.Networking.Interfaces.Ipv4.Info schema defines current IPv4 configuration state of a network interface.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Configurable** | **bool** | The specified network interface is configurable or not.  This property was added in __vSphere API 6.7__. | 
**Mode** | **string** | The Address assignment mode.  Possible values:   - &#x60;DHCP&#x60;: The IPv4 address is automatically assigned by a DHCP server.   - &#x60;STATIC&#x60;: The IPv4 address is static.   - &#x60;UNCONFIGURED&#x60;: The IPv4 protocol is not configured.   For more information see: *Appliance.Networking.Interfaces.Ipv4.Mode*.  This property was added in __vSphere API 6.7__. | 
**Address** | **string** | The IPv4 address, for example, \&quot;10.20.80.191\&quot;.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of mode is one of *Appliance.Networking.Interfaces.Ipv4.Mode.STATIC* or *Appliance.Networking.Interfaces.Ipv4.Mode.DHCP*. | [optional] 
**Prefix** | **long** | The IPv4 CIDR prefix, for example, 24. See http://www.oav.net/mirrors/cidr.html for netmask-to-prefix conversion.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of mode is one of *Appliance.Networking.Interfaces.Ipv4.Mode.STATIC* or *Appliance.Networking.Interfaces.Ipv4.Mode.DHCP*. | [optional] 
**DefaultGateway** | **string** | The IPv4 address of the default gateway. This configures the global default gateway on the appliance with the specified gateway address and interface. This gateway replaces the existing default gateway configured on the appliance. However, if the gateway address is link-local, then it is added for that interface. This does not support configuration of multiple global default gateways through different interfaces.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of mode is one of *Appliance.Networking.Interfaces.Ipv4.Mode.STATIC* or *Appliance.Networking.Interfaces.Ipv4.Mode.DHCP*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

