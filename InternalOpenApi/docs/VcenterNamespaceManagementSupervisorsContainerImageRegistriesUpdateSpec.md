# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsContainerImageRegistriesUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ContainerImageRegistries.UpdateSpec schema contains the specification required to update a container image registry.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the container image registry.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 
**Hostname** | **string** | IP address or the hostname of the container image registry.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 
**Port** | **long** | Port number of the container image registry.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 
**Username** | **string** | A username to be used for username/password authentication with this registry.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 
**Password** | **string** | The password for the user.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 
**CertificateChain** | **string** | The certificateChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the server.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 
**DefaultRegistry** | **bool** | Indicates if this registry is used as default.  When set true, the image registry will be used to host container images from Supervisor system components and services.   This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; then no update will be made. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

