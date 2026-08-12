# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsKubeApiServerSettingsInfo
The Vcenter.NamespaceManagement.Supervisors.Workloads.KubeApiServerSettings.Info schema contains information about the declared settings of the Kubernetes API Server.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateDnsNames** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Supervisors.Workloads.KubeApiServerSettings.Info.certificate_dns_names* lists additional DNS names to associate with the Kubernetes API Server.   These DNS names are embedded in the TLS certificate presented by the API Server as subject alternative names, which can be used in conjunction with your DNS Server to securely connect a client to the Server.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no DNS names are embedded in the TLS certificate. | 
**NamespaceApiFairnessEnabled** | **bool** | Information about whether control plane VM Kubernetes API fairness is enabled for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

