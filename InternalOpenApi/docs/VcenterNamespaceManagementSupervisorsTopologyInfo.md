# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsTopologyInfo
The Vcenter.NamespaceManagement.Supervisors.Topology.Info schema contains the basic information about the association between vSphere Zones and vSphere Clusters.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifier of this vSphere Zone.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Clusters** | **List&lt;string&gt;** | A list of vSphere Cluster identifiers that are associated with the vSphere Zone.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

