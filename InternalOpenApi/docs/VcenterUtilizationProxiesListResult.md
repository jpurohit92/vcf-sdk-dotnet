# Vcenter.Automation.OpenApi.Model.VcenterUtilizationProxiesListResult
The Vcenter.Utilization.Proxies.ListResult schema defines usage statistics for routes served by vCenter proxies. This includes backpressure status to determine the load for each upstream and usage breakdown by remote peer.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Proxies** | [**List&lt;VcenterUtilizationProxiesProxyInfo&gt;**](VcenterUtilizationProxiesProxyInfo.md) | Utilization of vCenter proxies.  This property was added in __vSphere API 9.1.0.0__. | 
**UnknownCriteria** | [**VcenterUtilizationProxiesFilterSpec**](VcenterUtilizationProxiesFilterSpec.md) | Filtering criteria that could not match any known properties.  This property was added in __vSphere API 9.1.0.0__.  if set, the filtering criteria which are unknown are returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

