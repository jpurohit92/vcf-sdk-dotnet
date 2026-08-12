# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersWorkloadNetworksInfo
The Vcenter.NamespaceManagement.Clusters.WorkloadNetworksInfo contains information related to configuration of vSphere Namespaces Network objects.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorPrimaryWorkloadNetwork** | [**VcenterNamespaceManagementNetworksInfo**](VcenterNamespaceManagementNetworksInfo.md) |   vSphere Namespaces network used by Kubernetes control plane VMs to access load-balanced services on the various workload networks.    This property was added in __vSphere API 7.0.1.0__. | 
**NetworkList** | [**List&lt;VcenterNamespaceManagementNetworksInfo&gt;**](VcenterNamespaceManagementNetworksInfo.md) | List of vSphere Namespaces networks associated with this cluster.  This property was added in __vSphere API 7.0.1.0__.  If missing or &#x60;null&#x60; no additional networks are associated with the cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

