# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLoadBalancersHAProxyConfigUpdateSpec
This schema is deprecated as of __vSphere API 9.0.0.0__.  Vcenter.NamespaceManagement.LoadBalancers.HAProxyConfigUpdateSpec captures the configuration data required for Supervisor Service Type:LoadBalancer to have an external load balancer be created via HAProxy.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  An administrator user name for accessing the HAProxy Data Plane API server.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the existing username will not be modified. | [optional] 
**Password** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The password for the administrator user.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the existing password will not be modified. | [optional] 
**CertificateAuthorityChain** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the existing PEM-encoded CA chain will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

