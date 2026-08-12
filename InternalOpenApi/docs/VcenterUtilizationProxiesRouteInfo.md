# Vcenter.Automation.OpenApi.Model.VcenterUtilizationProxiesRouteInfo
The Vcenter.Utilization.Proxies.RouteInfo schema defines a route in an HTTP proxy server.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The URI prefix for which this proxy route is responsible.  This property was added in __vSphere API 9.1.0.0__. | 
**Peers** | [**List&lt;VcenterUtilizationProxiesPeerInfo&gt;**](VcenterUtilizationProxiesPeerInfo.md) | The list of peers who are issuing requests to this route and the count of requests they have active.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, the peers issuing requests to this route could not be determined. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

