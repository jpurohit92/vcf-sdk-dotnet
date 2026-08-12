# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementZonesClusterCompatibilitiesCreateSpec
The Vcenter.NamespaceManagement.Zones.ClusterCompatibilities.CreateSpec schema contains the input parameters for creating a compatibility check for a vSphere Cluster Compute Resource to a vSphere Zone  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clusters** | **List&lt;string&gt;** | The identifiers for the vSphere Cluster Resources to check the compatibility for.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

