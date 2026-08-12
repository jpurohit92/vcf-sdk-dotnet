# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLoadBalancersAviConfigSetSpec
Vcenter.NamespaceManagement.LoadBalancers.AviConfigSetSpec captures the configuration data required for integration with the Avi Software Load Balancer.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | [**VcenterNamespaceManagementLoadBalancersServer**](VcenterNamespaceManagementLoadBalancersServer.md) | Server is the address for the Avi Controller, used to configure Virtual Servers. Note: This field cannot be updated and should match existing value.  This property was added in __vSphere API 7.0.3.0__. | 
**Username** | **string** | An administrator user name for accessing the Avi Controller.  This property was added in __vSphere API 7.0.3.0__. | 
**Password** | **string** | The password for the administrator user.  This property was added in __vSphere API 7.0.3.0__. | 
**CertificateAuthorityChain** | **string** | CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

