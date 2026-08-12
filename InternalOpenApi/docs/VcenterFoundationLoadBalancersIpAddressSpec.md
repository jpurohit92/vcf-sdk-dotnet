# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersIpAddressSpec
Vcenter.FoundationLoadBalancers.IpAddressSpec schema defines IP address configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | IP address assignment method.  Possible values:   - &#x60;DHCP&#x60;: IP address is automatically assigned by a DHCP server.   - &#x60;STATIC&#x60;: IP address is manually assigned.   For more information see: *Vcenter.FoundationLoadBalancers.IpAddressSpec.Type*.  This property was added in __vSphere API 9.0.0.0__. | 
**IpAddress** | **string** | IP address assigned to the node.  This property was added in __vSphere API 9.0.0.0__.  The field is required when assigning a STATIC type of IP address and skipped when assigning a DHCP type of IP address. The field is automatically populated with currently requested DHCP IP address. | [optional] 
**Prefix** | **long** | IP address prefix length.  This property was added in __vSphere API 9.0.0.0__.  The field is required when assigning a STATIC IP address and skipped when assigning a DHCP IP address. | [optional] 
**Personas** | **List&lt;string&gt;** | The network interface role, it can contain multiple roles used for different scenarios.  Possible values:   - &#x60;MANAGEMENT&#x60;: This type is intended for network interface with manager role.   - &#x60;FRONTEND&#x60;: This type is intended for network interface used for frontend.   - &#x60;BACKEND&#x60;: This type is intended for network interface used for backend.   For more information see: *Vcenter.FoundationLoadBalancers.IpAddressSpec.Persona*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, keep current configuration unset or unchanged. | [optional] 
**Gateway** | **string** | The default gateway address of the load balancer node, address in CIDR format, e.g., 10.0.0.1/24.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the default gateway keeps unset or unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

