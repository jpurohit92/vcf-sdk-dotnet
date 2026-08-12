# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersFilterSpec
The Vcenter.FoundationLoadBalancers.FilterSpec schema contains parameters used for filter the results when listing load balancers.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **string** | The creator name of load balancer.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, it won&#39;t match creator information when listing load balancers. | [optional] 
**OwnerId** | **string** | The load balancer creator identifier.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, it won&#39;t match creator information when listing load balancers. | [optional] 
**Name** | **string** | The load balancer name.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, it won&#39;t match load balancer name when listing load balancers. | [optional] 
**FullInfo** | **bool** | The field indicates whether to get load balancer detailed info list, if the value is true, get load balancer detailed info list and ID list, if the value is false, get load balancer ID list only.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; means get load balancer ID list only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

