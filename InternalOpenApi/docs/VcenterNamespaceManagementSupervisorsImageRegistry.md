# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsImageRegistry
The Vcenter.NamespaceManagement.Supervisors.ImageRegistry schema contains the specification required to configure container image registry endpoint.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | IP address or the hostname of container image registry.  This property was added in __vSphere API 8.0.0.1__. | 
**Port** | **long** | Port number of the container image registry.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, defaults to 443. | [optional] 
**Username** | **string** | A username to be used for username/password authentication with this registry.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then the username/password authentication will not be used. | [optional] 
**Password** | **string** | The password for the user.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then the password is unset, only for write operations. For read operations (GET and LIST), this value is always nil. | [optional] 
**CertificateChain** | **string** | PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then the verification will be skipped. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

