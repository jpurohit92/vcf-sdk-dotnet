# Vcenter.Automation.OpenApi.Model.VcenterUtilizationProxiesProxyInfo
The Vcenter.Utilization.Proxies.ProxyInfo schema describes an HTTP proxy which handles traffic in vCenter.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The vCenter service which proxies HTTP requests.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.services.Service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.services.Service&#x60;. | 
**Upstreams** | [**List&lt;VcenterUtilizationProxiesUpstreamInfo&gt;**](VcenterUtilizationProxiesUpstreamInfo.md) | The list of upstreams that are handled by this proxy.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

