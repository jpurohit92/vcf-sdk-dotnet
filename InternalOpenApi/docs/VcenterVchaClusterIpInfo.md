# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterIpInfo
The Vcenter.Vcha.Cluster.IpInfo schema contains properties related to an ip.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpFamily** | **string** | Family of the ip.  Possible values:   - &#x60;IPV4&#x60;: IPV4 address family.   - &#x60;IPV6&#x60;: IPV6 address family.   For more information see: *Vcenter.Vcha.Cluster.IpFamily*.  This property was added in __vSphere API 6.7.1__. | 
**Ipv4** | [**VcenterVchaClusterIpv4Info**](VcenterVchaClusterIpv4Info.md) | If the type of the ip family is IPV4, then this will point to IPv4 address specification.  This property was added in __vSphere API 6.7.1__.  This property is optional and it is only relevant when the value of ip_family is *Vcenter.Vcha.Cluster.IpFamily.IP_v4*. | [optional] 
**Ipv6** | [**VcenterVchaClusterIpv6Info**](VcenterVchaClusterIpv6Info.md) | If the type of the ip family is IPV6, then this will point to IPv6 address specification.  This property was added in __vSphere API 6.7.1__.  This property is optional and it is only relevant when the value of ip_family is *Vcenter.Vcha.Cluster.IpFamily.IP_v6*. | [optional] 
**GatewayIp** | **string** | Gateway IP address.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, no gateway is specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

