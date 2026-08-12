# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloadsKubeApiServerSettingsUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Workloads.KubeApiServerSettings.UpdateSpec schema contains updates to settings declared for the Kubernetes API Server.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateDnsNamesToAddList** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Supervisors.Workloads.KubeApiServerSettings.UpdateSpec.certificate_dns_names_to_add_list* lists additional DNS names to associate with the Kubernetes API Server.   These DNS names are embedded in the TLS certificate presented by the API Server as subject alternative names, which can be used in conjunction with your DNS Server to securely connect a client to the Server.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no DNS names will be added to the TLS certificate. | [optional] 
**CertificateDnsNamesToRemoveList** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Supervisors.Workloads.KubeApiServerSettings.UpdateSpec.certificate_dns_names_to_remove_list* lists DNS names to dis-associate from the Kubernetes API Server.   These DNS names are embedded in the TLS certificate presented by the API Server as subject alternative names, which can be used in conjunction with your DNS Server to securely connect a client to the Server.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no certificate DNS names will be removed from the TLS certificate. | [optional] 
**NamespaceApiFairnessEnabled** | **bool** | Update control plane VM Kubernetes API fairness for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the control plane VM Kubernetes API fairness is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

