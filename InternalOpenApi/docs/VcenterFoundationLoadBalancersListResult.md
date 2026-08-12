# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersListResult
The Vcenter.FoundationLoadBalancers.ListResult schema contains commonly used information about a load balancer.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoadBalancers** | **List&lt;string&gt;** | Identifier(s) of load balancer.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.FoundationLoadBalancer&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.FoundationLoadBalancer&#x60;. | 
**Infos** | [**List&lt;VcenterFoundationLoadBalancersInfo&gt;**](VcenterFoundationLoadBalancersInfo.md) | Detailed info list of load balancer.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; means client doesn&#39;t intend to get a detailed info list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

