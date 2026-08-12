# Vcenter.Automation.OpenApi.Model.VcenterGuestIpv4
The Vcenter.Guest.Ipv4 schema specifies the IPv4 settings that need to be applied to a virtual network adapter.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the IPv4 configuration.  Possible values:   - &#x60;DHCP&#x60;: DHCP configuration   - &#x60;STATIC&#x60;: Static configuration   - &#x60;USER_INPUT_REQUIRED&#x60;: Indicates that the IPv4 settings are not specified in advance. The user must provide a valid value when the actual customization spec is applied to a virtual machine.   - &#x60;DISABLED&#x60;: Disable configuration. Indicates that the IPv4 settings of the virtual network adapter are disabled.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Vcenter.Guest.Ipv4.Type*.  This property was added in __vSphere API 7.0.0.0__. | 
**IpAddress** | **string** | The static IPv4 address  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Ipv4.Type.STATIC*. | [optional] 
**Prefix** | **long** | The IPv4 CIDR prefix, for example, 24. See http://www.oav.net/mirrors/cidr.html for netmask-to-prefix conversion.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Ipv4.Type.STATIC*. | [optional] 
**Gateways** | **List&lt;string&gt;** | Gateways for the IPv4 address.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no gateways are set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

