# Vcenter.Automation.OpenApi.Model.VcenterFoundationLoadBalancersControllerSpec
Vcenter.FoundationLoadBalancers.ControllerSpec schema defines information for load balancer node(s) connecting to controller.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Jwt** | **string** | Token used by load balancer node(s) to authenticate with the controller.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, load balancer node(s) won&#39;t have a token in JWT format when accessing load balancer controller. | [optional] 
**TrustedCa** | [**VcenterTrustedInfrastructureX509CertChain**](VcenterTrustedInfrastructureX509CertChain.md) | The TLS certificate chain of the load balancer used by load balancer node(s) to verify the load balancer controller.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, load balancer node(s) will stop certificate verification workflow for load balancer controller. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

