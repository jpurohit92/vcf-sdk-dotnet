# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersWorkloadNetworksEnableSpec
The Vcenter.NamespaceManagement.Clusters.WorkloadNetworksEnableSpec contains the specification required to configure workload networks for a vSphere Namespaces Cluster during Enable operation. These workload networks will be used as backing network for Kubernetes Cluster VMs and Kubernetes control plane VMs.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorPrimaryWorkloadNetwork** | [**VcenterNamespaceManagementNetworksCreateSpec**](VcenterNamespaceManagementNetworksCreateSpec.md) | The *Vcenter.NamespaceManagement.Networks.CreateSpec* of the vSphere Namespaces network that will be used by Kubernetes control plane VMs to expose Kubernetes API server to devops users and other workloads. It can also used as backing network for Kubernetes Cluster VMs.   The network&#39;s *Vcenter.NamespaceManagement.Networks.IPAssignmentMode* cannot be *Vcenter.NamespaceManagement.Networks.IPAssignmentMode.NONE*.  This property was added in __vSphere API 7.0.1.0__. | 
**NetworkList** | [**List&lt;VcenterNamespaceManagementNetworksCreateSpec&gt;**](VcenterNamespaceManagementNetworksCreateSpec.md) | *Vcenter.NamespaceManagement.Networks.CreateSpec* schemaes for additional list of vSphere Namespaces networks to be associated with this cluster.  This property was added in __vSphere API 7.0.1.0__.  If missing or &#x60;null&#x60; no additional networks will be associated with the cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

