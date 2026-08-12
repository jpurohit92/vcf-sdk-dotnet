# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCertificatesInfo
The Vcenter.NamespaceManagement.Supervisors.Certificates.Info schema contains information about the PEM-encoded x509 certificate(s) used by Supervisor endpoints.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TlsEndpointCertificate** | **string** | PEM-encoded x509 certificate used by Supervisor TLS endpoint.   In case of a certificate chain, the order of the certificates in this field is important. The first certificate must be the leaf certificate for your domain name, followed by the intermediate certificate(s), and conclude with the root certificate.  This property was added in __vSphere API 9.1.0.0__. | 
**Endpoint** | **string** | Supervisor TLS endpoint for which certificate is configured.  Possible values:   - &#x60;VIP&#x60;: TLS endpoint on Kubernetes API servers when accessed via the load balancer.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Certificates.EndpointType*.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

