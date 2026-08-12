# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksEdgesHAProxyUpdateSpec
This schema is deprecated as of __vSphere API 9.0.0.0__.  The Vcenter.NamespaceManagement.Supervisors.Networks.Edges.HAProxyUpdateSpec defines parameters for updating an HAProxy Load Balancer.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressRanges** | [**List&lt;VcenterNamespaceManagementSupervisorsNetworksEdgesIPRange&gt;**](VcenterNamespaceManagementSupervisorsNetworksEdgesIPRange.md) | This property is deprecated as of __vSphere API 9.0.0.0__.  List of address ranges that will be used to derive frontend IP addresses for L4 virtual servers. At least one range must be provided. An update operation only allows for addition of new IP ranges to the existing list of IP ranges.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the existing list of address ranges will not be modified. | [optional] 
**Username** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  An administrator user name for accessing the HAProxy Data Plane API server.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the existing username will not be modified. | [optional] 
**Password** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  The password for the administrator user.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the existing password will not be modified. | [optional] 
**CertificateAuthorityChain** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__.  CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the existing PEM-encoded CA chain will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

