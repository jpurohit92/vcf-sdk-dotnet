# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingFirewallInboundRule
Appliance.Networking.Firewall.Inbound.Rule schema Structure that defines a single address-based firewall rule.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | IPv4 or IPv6 address.  This property was added in __vSphere API 6.7.1__. | 
**Prefix** | **long** | CIDR prefix used to mask address. For example, an IPv4 prefix of 24 ignores the low-order 8 bits of address.  This property was added in __vSphere API 6.7.1__. | 
**Policy** | **string** | The allow or deny policy of this rule.  Possible values:   - &#x60;IGNORE&#x60;: Drop packet with correpsonding address.   - &#x60;ACCEPT&#x60;: Allow packet with corresponding address.   - &#x60;REJECT&#x60;: Drop packet with corresponding address sending destination is not reachable.   - &#x60;RETURN&#x60;: Apply default or port-specific rules to packet with corresponding address.   For more information see: *Appliance.Networking.Firewall.Inbound.Policy*.  This property was added in __vSphere API 6.7.1__. | 
**InterfaceName** | **string** | The interface to which this rule applies. An empty string indicates that the rule applies to all interfaces.  This property was added in __vSphere API 6.7.1__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

