# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersNetworkInterfaceSpec
Vcenter.FoundationLoadBalancers.NetworkInterfaceSpec schema defines the information that is used for creating network interface.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpSettings** | [**List&lt;VcenterFoundationLoadBalancersIpAddressSpec&gt;**](VcenterFoundationLoadBalancersIpAddressSpec.md) | IP configuration of the network interface.  This property was added in __vSphere API 9.0.0.0__.  The field is required for deployment but optional for updating, If missing or &#x60;null&#x60;, the IP configuration on the network interface will keep unchanged. | [optional] 
**Network** | **string** | The network to which the interface is attached.  This property was added in __vSphere API 9.0.0.0__.  The field is required for deployment but optional for updating, If missing or &#x60;null&#x60;, current network configuration will keep unchanged.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | [optional] 
**DeviceId** | **string** | The network interface device identifier.  This property was added in __vSphere API 9.0.0.0__.  The field is not required when updating an existing network interface or creating a new one. It would be filled when getting the information of the load balancer node, if missing or &#x60;null&#x60; indicates the network interface is not ready. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

