# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesNSXAdvancedLBConfig
Vcenter.NamespaceManagement.Networks.Edges.NSXAdvancedLBConfig schema is used to describe the NSX Advanced Load Balancer configuration.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | [**VcenterNamespaceManagementNetworksEdgesServer**](VcenterNamespaceManagementNetworksEdgesServer.md) | *Vcenter.NamespaceManagement.Networks.Edges.NSXAdvancedLBConfig.server* is the address for the Avi Controller, used to configure Virtual Servers.  This property was added in __vSphere API 8.0.0.1__. | 
**Username** | **string** | *Vcenter.NamespaceManagement.Networks.Edges.NSXAdvancedLBConfig.username* is used by the Avi Kubernetes Operator to program the Avi Controller.  This property was added in __vSphere API 8.0.0.1__. | 
**Password** | **string** | *Vcenter.NamespaceManagement.Networks.Edges.NSXAdvancedLBConfig.password* is the password for the username.  This property was added in __vSphere API 8.0.0.1__. | 
**CertificateAuthorityChain** | **string** | *Vcenter.NamespaceManagement.Networks.Edges.NSXAdvancedLBConfig.certificate_authority_chain* contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 8.0.0.1__. | 
**CloudName** | **string** | The cloud name for the Avi Controller.  This property was added in __vSphere API 8.0.2.00300__.  Only set if custom cloud name is configured for this Avi Controller. If missing or &#x60;null&#x60;, it defaults to \&quot;Default-Cloud\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

