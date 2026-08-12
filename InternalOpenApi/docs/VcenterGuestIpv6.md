# Vcenter.Automation.OpenApi.Model.VcenterGuestIpv6
The Vcenter.Guest.Ipv6 schema specifies the IPv6 settings that need to be applied to a virtual network adapter.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The IPv6 configuration type  Possible values:   - &#x60;DHCP&#x60;: DHCP IPv6 configuration.   - &#x60;STATIC&#x60;: Static IPv6 configuration.   - &#x60;USER_INPUT_REQUIRED&#x60;: Indicates that the IPv6 settings are not specified in advance. The user must provide a valid value when the actual customization spec is applied to a virtual machine.   For more information see: *Vcenter.Guest.Ipv6.Type*.  This property was added in __vSphere API 7.0.0.0__. | 
**Ipv6** | [**List&lt;VcenterGuestIpv6Address&gt;**](VcenterGuestIpv6Address.md) | IPv6 address  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Ipv6.Type.STATIC*. | [optional] 
**Gateways** | **List&lt;string&gt;** | gateways for the IPv6 address.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no gateways are set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

