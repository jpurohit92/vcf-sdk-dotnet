# Vcenter.Automation.OpenApi.Model.VcenterConsumptionDomainsZonesClusterAssociationsStatus
The Vcenter.ConsumptionDomains.Zones.Cluster.Associations.Status schema contains information about the outcome of the operation to add a set of vSphere clusters to a zone or the operation to remove a set of vSphere clusters from a zone. It also contains information about the partial failures, in case the addition/removal failed for a subset of clusters.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | This is true if the complete operation succeeded without any errors. Otherwise, it is false if all or some operations have failed.  This property was added in __vSphere API 8.0.0.1__. | 
**FailedClusters** | **Dictionary&lt;string, Object&gt;** | Associations between the identifiers of the clusters for which the operation failed and the reason of the failure.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

