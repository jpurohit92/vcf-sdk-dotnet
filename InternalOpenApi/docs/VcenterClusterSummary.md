# Vcenter.Automation.OpenApi.Model.VcenterClusterSummary
The Vcenter.Cluster.Summary schema contains commonly used information about a cluster in vCenter Server.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | Identifier of the cluster.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**Name** | **string** | Name of the cluster. | 
**HaEnabled** | **bool** | Flag indicating whether the vSphere HA feature is enabled for the cluster. | 
**DrsEnabled** | **bool** | Flag indicating whether the vSphere DRS service is enabled for the cluster. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

