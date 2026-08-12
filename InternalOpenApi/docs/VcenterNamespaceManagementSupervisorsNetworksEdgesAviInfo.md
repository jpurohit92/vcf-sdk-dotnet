# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksEdgesAviInfo
Vcenter.NamespaceManagement.Supervisors.Networks.Edges.AviInfo contains detailed information about an Avi Load Balancer.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | [**VcenterNamespaceManagementSupervisorsNetworksEdgesServer**](VcenterNamespaceManagementSupervisorsNetworksEdgesServer.md) | Server is the address for the Avi Controller used to configure Virtual Servers.  This property was added in __vSphere API 9.0.0.0__. | 
**Username** | **string** | An administrator user name for accessing the Avi Controller.  This property was added in __vSphere API 9.0.0.0__. | 
**CertificateAuthorityChain** | **string** | PEM-encoded CA certificate chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 9.0.0.0__. | 
**CloudName** | **string** | The cloud name for the Avi Controller.  This property was added in __vSphere API 9.0.0.0__.  Only set if custom cloud name is configured for this Avi Controller. If missing or &#x60;null&#x60;, it defaults to \&quot;Default-Cloud\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

