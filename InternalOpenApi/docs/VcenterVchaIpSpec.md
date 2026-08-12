# Vcenter.Automation.OpenApi.Model.VcenterVchaIpSpec
The Vcenter.Vcha.IpSpec schema contains IP information used to configure a network interface.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpFamily** | **string** | Family of the IP address to configure the interface.  Possible values:   - &#x60;IPV4&#x60;: IPV4 address family   - &#x60;IPV6&#x60;: IPv6 address family   For more information see: *Vcenter.Vcha.IpFamily*.  This property was added in __vSphere API 6.7.1__. | 
**Ipv4** | [**VcenterVchaIpv4Spec**](VcenterVchaIpv4Spec.md) | If the family of the ip is IPV4, then this will point to IPv4 address specification.  This property was added in __vSphere API 6.7.1__.  This property is optional and it is only relevant when the value of ip_family is *Vcenter.Vcha.IpFamily.IP_v4*. | [optional] 
**Ipv6** | [**VcenterVchaIpv6Spec**](VcenterVchaIpv6Spec.md) | If the family of the ip is IPV6, then this will point to IPv6 address specification.  This property was added in __vSphere API 6.7.1__.  This property is optional and it is only relevant when the value of ip_family is *Vcenter.Vcha.IpFamily.IP_v6*. | [optional] 
**DefaultGateway** | **string** | The IP address of the Gateway for this interface.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, gateway will not be used for the network interface. | [optional] 
**DnsServers** | **List&lt;string&gt;** | The list of IP addresses of the DNS servers for this interface. This list is a comma separated list.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, DNS servers will not be used for the network interface. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

