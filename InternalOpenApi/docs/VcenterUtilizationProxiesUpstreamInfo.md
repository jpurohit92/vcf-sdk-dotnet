# Vcenter.Automation.OpenApi.Model.VcenterUtilizationProxiesUpstreamInfo
The Vcenter.Utilization.Proxies.UpstreamInfo schema defines the backpressure status of a set of HTTP routes which share backpressure restrictions.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the upstream. This name should be treated as an opaque value. It allows observing the usage of this upstream across different proxies.  This property was added in __vSphere API 9.1.0.0__. | 
**Routes** | [**List&lt;VcenterUtilizationProxiesRouteInfo&gt;**](VcenterUtilizationProxiesRouteInfo.md) | The list of HTTP routes that are subject to backpressure restrictions.  This property was added in __vSphere API 9.1.0.0__. | 
**RequestsBackPressure** | [**VcenterUtilizationProxiesBackpressureInfo**](VcenterUtilizationProxiesBackpressureInfo.md) | The backpressure status of the requests aimed towards those *Vcenter.Utilization.Proxies.UpstreamInfo.routes*. This tells whether the list of *Vcenter.Utilization.Proxies.UpstreamInfo.routes* can handle more HTTP requests or they are being backpressured.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

