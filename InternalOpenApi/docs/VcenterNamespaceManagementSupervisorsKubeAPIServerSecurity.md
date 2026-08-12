# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsKubeAPIServerSecurity
Vcenter.NamespaceManagement.Supervisors.KubeAPIServerSecurity schema declares security options configured on the Kubernetes API server.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateDnsNames** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Supervisors.KubeAPIServerSecurity.certificate_dns_names* lists additional DNS names to associate with the Kubernetes API server.   These DNS names are embedded in the TLS certificate presented by the API server as subject alternative names, which can be used in conjunction with your DNS server to securely connect a client to the server.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, no additional DNS names are embedded in the TLS certificate. Clients should use the IP address of the API server to connect securely. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

