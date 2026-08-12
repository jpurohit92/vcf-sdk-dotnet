# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLoadBalancersAviConfigUpdateSpec
Vcenter.NamespaceManagement.LoadBalancers.AviConfigUpdateSpec captures the configuration data required for integration with the Avi Software Load Balancer.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | An administrator user name for accessing the Avi Controller.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the existing username will not be modified. | [optional] 
**Password** | **string** | The password for the administrator user.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the existing password will not be modified. | [optional] 
**CertificateAuthorityChain** | **string** | CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the existing PEM-encoded CA chain will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

