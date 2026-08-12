# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareClustersSummary
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Software.Clusters.Summary schema contains basic information about the cluster upgrade related information.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Identifier for the cluster.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**ClusterName** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Name of the cluster.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource.name&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource.name&#x60;. | 
**CurrentVersion** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Current version of the cluster.  This property was added in __vSphere API 7.0.0.0__. | 
**AvailableVersions** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 9.1.0.0__.  Set of versions available for upgrade.  This property was added in __vSphere API 7.0.0.0__. | 
**LastUpgradedDate** | **DateTime** | This property is deprecated as of __vSphere API 9.1.0.0__.  Date of last successful upgrade.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the cluster has not yet been upgraded. | [optional] 
**DesiredVersion** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Desired version the cluster will be upgraded to.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the cluster upgrade is not in progress. | [optional] 
**State** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Current state of the upgrade.  Possible values:   - &#x60;PENDING&#x60;: Upgrade is in progress.   - &#x60;READY&#x60;: Cluster is ready when there is no upgrade or upgrade is completed.   - &#x60;ERROR&#x60;: Upgrade failed and need user intervention.   For more information see: *Vcenter.NamespaceManagement.Software.Clusters.State*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

