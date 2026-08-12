# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersUtilizationInfo
The Vcenter.FoundationLoadBalancers.UtilizationInfo schema defines the combined utilization status, it contains cpu, memory currently.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cpu** | **string** | CPU utilization. If the utilization is below 75%, the status is GREEN. If utilization is between 75% and 90% for more than 5 minutes, the status changes to YELLOW. If utilization exceeds 90% for more than 5 minutes, the status changes to RED.  Possible values:   - &#x60;INVALID&#x60;: The status means can&#39;t get the utilization status.   - &#x60;GREEN&#x60;: The utilization status is *Vcenter.FoundationLoadBalancers.UtilizationStatus.GREEN*.   - &#x60;YELLOW&#x60;: The utilization status is *Vcenter.FoundationLoadBalancers.UtilizationStatus.YELLOW*.   - &#x60;RED&#x60;: The utilization status is *Vcenter.FoundationLoadBalancers.UtilizationStatus.RED*.   For more information see: *Vcenter.FoundationLoadBalancers.UtilizationStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Memory** | **string** | Memory utilization. If the utilization is below 85%, the status is GREEN. If utilization is between 85% and 95% for more than 10 minutes, the status changes to YELLOW. If utilization exceeds 95% for more than 10 minutes, the status changes to RED.  Possible values:   - &#x60;INVALID&#x60;: The status means can&#39;t get the utilization status.   - &#x60;GREEN&#x60;: The utilization status is *Vcenter.FoundationLoadBalancers.UtilizationStatus.GREEN*.   - &#x60;YELLOW&#x60;: The utilization status is *Vcenter.FoundationLoadBalancers.UtilizationStatus.YELLOW*.   - &#x60;RED&#x60;: The utilization status is *Vcenter.FoundationLoadBalancers.UtilizationStatus.RED*.   For more information see: *Vcenter.FoundationLoadBalancers.UtilizationStatus*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

