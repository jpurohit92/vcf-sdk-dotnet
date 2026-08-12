# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersSizingSpec
Vcenter.FoundationLoadBalancers.SizingSpec schema defines the capacity of load balancer node(s).  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReserveCpu** | **bool** | CPU resource reservation: If set to false, no CPU resource is reserved. If set to true, the CPU matching the specified *Vcenter.FoundationLoadBalancers.NodeSize* is fully reserved. If the load balancer node size *Vcenter.FoundationLoadBalancers.NodeSize* is changed, the new size will also be fully reserved. The CPU reservation is calculated as 1GHZ * number of CPUs.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, there is no CPU reserved. | [optional] 
**ReserveMem** | **bool** | Memory resource reservation: If set to false, no memory resource is reserved. If set to true, the memory matching the specified *Vcenter.FoundationLoadBalancers.NodeSize* is fully reserved. If the load balancer node size *Vcenter.FoundationLoadBalancers.NodeSize* is changed, the new size will also be fully reserved.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, there is no memory reserved. | [optional] 
**Size** | **string** | Deployment size of load balancer node(s).  Possible values:   - &#x60;SMALL&#x60;: *Vcenter.FoundationLoadBalancers.NodeSize.SMALL* allocates 2 CPUs, 4 GB memory, and 8 GB storage for deployment.   - &#x60;MEDIUM&#x60;: *Vcenter.FoundationLoadBalancers.NodeSize.MEDIUM* allocates 4 CPUs, 8 GB memory, and 8 GB storage for deployment.   - &#x60;LARGE&#x60;: *Vcenter.FoundationLoadBalancers.NodeSize.LARGE* allocates 8 CPUs, 12 GB memory, and 8 GB storage for deployment.   - &#x60;X_LARGE&#x60;: *Vcenter.FoundationLoadBalancers.NodeSize.X_LARGE* allocates 16 CPUs, 16 GB memory, and 8 GB storage for deployment.   For more information see: *Vcenter.FoundationLoadBalancers.NodeSize*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, its default value is MEDIUM. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

