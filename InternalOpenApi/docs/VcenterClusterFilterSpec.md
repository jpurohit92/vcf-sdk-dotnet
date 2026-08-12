# Vcenter.Automation.OpenApi.Model.VcenterClusterFilterSpec
The Vcenter.Cluster.FilterSpec schema contains properties used to filter the results when listing clusters (see *GET /vcenter/cluster*). If multiple properties are specified, only clusters matching all of the properties match the filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clusters** | **List&lt;string&gt;** | Identifiers of clusters that can match the filter.  If missing or &#x60;null&#x60; or empty, clusters with any identifier match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Names** | **List&lt;string&gt;** | Names that clusters must have to match the filter (see *Vcenter.Cluster.Info.name*).  If missing or &#x60;null&#x60; or empty, clusters with any name match the filter. | [optional] 
**Folders** | **List&lt;string&gt;** | Folders that must contain the cluster for the cluster to match the filter.  If missing or &#x60;null&#x60; or empty, clusters in any folder match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Folder&#x60;. | [optional] 
**Datacenters** | **List&lt;string&gt;** | Datacenters that must contain the cluster for the cluster to match the filter.  If missing or &#x60;null&#x60; or empty, clusters in any datacenter match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datacenter&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datacenter&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

