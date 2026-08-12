# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonNetwork
The Vcenter.Lcm.Deployment.Common.Network schema defines the network configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpFamily** | **string** | Network IP address family.  Possible values:   - &#x60;IPV4&#x60;: IPv4 Type of IP address.   - &#x60;IPV6&#x60;: IPv6 Type of IP address.   For more information see: *Vcenter.Lcm.Deployment.Common.Network.IpType*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; defaults to IPv4 | [optional] 
**Mode** | **string** | Network mode.  Possible values:   - &#x60;DHCP&#x60;: DHCP mode.   - &#x60;STATIC&#x60;: Static IP mode.   For more information see: *Vcenter.Lcm.Deployment.Common.Network.NetworkMode*.  This property was added in __vSphere API 9.0.0.0__. | 
**Ip** | **string** | Network IP address. Required for static mode only.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of mode is *Vcenter.Lcm.Deployment.Common.Network.NetworkMode.STATIC*. | [optional] 
**DnsServers** | **List&lt;string&gt;** | A comma-separated list of IP addresses of DNS servers.Required for static mode only. A JSON array such as [\&quot;1.2.3.4\&quot;, \&quot;127.0.0.1\&quot;]. The DNS servers must be reachable from the source appliance and only the first two will be used.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of mode is *Vcenter.Lcm.Deployment.Common.Network.NetworkMode.STATIC*. | [optional] 
**Prefix** | **long** | Network prefix length. Required for static mode only. This is the number of bits set in the subnet mask; for instance, if the subnet mask is 255.255.255.0, there are 24 bits in the binary version of the subnet mask, so the prefix length is 24. If used, the values must be in the inclusive range of 0 to 32 for IPv4 and 0 to 128 for IPv6.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of mode is *Vcenter.Lcm.Deployment.Common.Network.NetworkMode.STATIC*. | [optional] 
**Gateway** | **string** | Gateway of the network. Required for static mode only.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of mode is *Vcenter.Lcm.Deployment.Common.Network.NetworkMode.STATIC*. | [optional] 
**Hostname** | **string** | Primary network identity. Can be either an IP address or a fully qualified domain name(FQDN).  This property was added in __vSphere API 9.0.0.0__.  hostname may not be applicable | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

