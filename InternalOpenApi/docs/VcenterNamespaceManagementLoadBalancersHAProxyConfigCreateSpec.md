# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLoadBalancersHAProxyConfigCreateSpec
This schema is deprecated as of __vSphere API 9.0.0.0__.  Vcenter.NamespaceManagement.LoadBalancers.HAProxyConfigCreateSpec captures the configuration data required for Supervisor Service Type:LoadBalancer to have an external load balancer be created via HAProxy.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | [**List&lt;VcenterNamespaceManagementLoadBalancersServer&gt;**](VcenterNamespaceManagementLoadBalancersServer.md) | This property is deprecated as of __vSphere API 9.0.0.0__.  Servers is a list of the addresses for the data plane API servers used to configure Virtual Servers.  This property was added in __vSphere API 7.0.1.0__. | 
**Username** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  An administrator user name for accessing the HAProxy Data Plane API server.  This property was added in __vSphere API 7.0.1.0__. | 
**Password** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The password for the administrator user.  This property was added in __vSphere API 7.0.1.0__. | 
**CertificateAuthorityChain** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 7.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

