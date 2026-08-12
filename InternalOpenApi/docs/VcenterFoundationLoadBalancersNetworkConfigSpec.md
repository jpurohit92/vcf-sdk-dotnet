# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersNetworkConfigSpec
The Vcenter.FoundationLoadBalancers.NetworkConfigSpec schema defines load balancer node(s) network configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NtpServers** | **List&lt;string&gt;** | The NTP server IP addresses of the load balancer node(s).  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the ntpServers keep unchanged on load balancer node(s). | [optional] 
**Dns** | [**VcenterFoundationLoadBalancersDNS**](VcenterFoundationLoadBalancersDNS.md) | The DNS servers and search domains for a given network.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the servers and search domains keep unchanged on load balancer node(s). | [optional] 
**ExtraVipSubnets** | **List&lt;string&gt;** | The extra VIP subnets of the load balancer node(s) in CIDR format.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the extraVipSubnets keep unchanged on load balancer node(s). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

