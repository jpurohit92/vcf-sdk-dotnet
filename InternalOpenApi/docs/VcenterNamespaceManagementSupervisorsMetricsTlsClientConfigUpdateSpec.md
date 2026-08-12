# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsMetricsTlsClientConfigUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Metrics.TlsClientConfigUpdateSpec schema contains TLS configuration used by the Supervisor when sending metrics to a remote endpoint.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateAuthorityChain** | **string** | Certificate authority chain holds the trusted roots to be used to establish HTTPS connections with the remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, certificate authority data will not be modified. | [optional] 
**ClientCertificate** | **string** | A PEM-encoded x509 certificate used by the Supervisor for TLS authentication when sending metrics to a remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, certificate will not be modified. | [optional] 
**ClientPrivateKey** | **string** | Private key associated with the *Vcenter.NamespaceManagement.Supervisors.Metrics.TlsClientConfigUpdateSpec.client_certificate*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, private key will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

