# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesHAProxyConfig
This schema is deprecated as of __vSphere API 9.0.0.0__.  Vcenter.NamespaceManagement.Networks.Edges.HAProxyConfig schema describes configuration for the HAProxy Load Balancer.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | [**List&lt;VcenterNamespaceManagementNetworksEdgesServer&gt;**](VcenterNamespaceManagementNetworksEdgesServer.md) | This property is deprecated as of __vSphere API 9.0.0.0__.  *Vcenter.NamespaceManagement.Networks.Edges.HAProxyConfig.servers* is a list of the addresses for the data plane API servers used to configure Virtual Servers.  This property was added in __vSphere API 8.0.0.1__. | 
**Username** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  *Vcenter.NamespaceManagement.Networks.Edges.HAProxyConfig.username* is used by the HAProxy Kubernetes Operator to program the HAProxy Controller.  This property was added in __vSphere API 8.0.0.1__. | 
**Password** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  *Vcenter.NamespaceManagement.Networks.Edges.HAProxyConfig.password* secures the *Vcenter.NamespaceManagement.Networks.Edges.HAProxyConfig.username*.  This property was added in __vSphere API 8.0.0.1__. | 
**CertificateAuthorityChain** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  *Vcenter.NamespaceManagement.Networks.Edges.HAProxyConfig.certificate_authority_chain* contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

