# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLoadBalancersAviConfigCreateSpec
Vcenter.NamespaceManagement.LoadBalancers.AviConfigCreateSpec captures the configuration data required for integration with the Avi Software Load Balancer.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | [**VcenterNamespaceManagementLoadBalancersServer**](VcenterNamespaceManagementLoadBalancersServer.md) | Server is the address for the Avi Controller, used to configure Virtual Servers.  This property was added in __vSphere API 7.0.2.0__. | 
**Username** | **string** | An administrator user name for accessing the Avi Controller.  This property was added in __vSphere API 7.0.2.0__. | 
**Password** | **string** | The password for the administrator user.  This property was added in __vSphere API 7.0.2.0__. | 
**CertificateAuthorityChain** | **string** | CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 7.0.2.0__. | 
**CloudName** | **string** | The cloud name for the Avi Controller.  This property was added in __vSphere API 8.0.2.00300__.  Only set if custom cloud name is configured for this Avi Controller. If missing or &#x60;null&#x60;, it defaults to \&quot;Default-Cloud\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

