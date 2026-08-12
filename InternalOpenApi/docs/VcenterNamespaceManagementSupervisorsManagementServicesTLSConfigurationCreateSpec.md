# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsManagementServicesTLSConfigurationCreateSpec
The Vcenter.NamespaceManagement.Supervisors.ManagementServices.TLSConfigurationCreateSpec schema specifies the TLS configuration of a Management Service being created.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateAuthorityChain** | **string** | PEM-encoded X509 CA Chain that can be used to verify the certificate returned by the Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no CA Chain will be available to clients of the Management Service in this Supervisor. If the service exposed by the Management Service uses TLS, such clients are expected to discover the CA chain required to validate the server certificate through some other means. | [optional] 
**Hostname** | **string** | The Server Name Indication (SNI) that a client should use to connect to the Management Service, and should match the certificate served by the Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no SNI hostname will be available to clients of the Management Service in this Supervisor. If this service requires clients to use of SNI, such clients are expected to discover the SNI value through some other means. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

