# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsApplyImpactClusterImpact
The Esx.Settings.Clusters.Software.Reports.ApplyImpact.ClusterImpact schema contains properties that describe the summary of how hosts within a cluster will be impacted during an apply operation.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Impact** | [**List&lt;EsxSettingsClustersSoftwareReportsApplyImpactImpact&gt;**](EsxSettingsClustersSoftwareReportsApplyImpactImpact.md) | Impact of steps performed during the setup and cleanup phase of the apply operation.  This property was added in __vSphere API 7.0.0.0__. | 
**HostImpact** | **Dictionary&lt;string, List&lt;EsxSettingsClustersSoftwareReportsApplyImpactImpact&gt;&gt;** | Impact summary for each host within the clsuter.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**Commit** | **string** | Identifier of the commit on which the impact is generated.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | 
**HostInfo** | [**Dictionary&lt;string, EsxSettingsHostInfo&gt;**](EsxSettingsHostInfo.md) | Information of hosts within the cluster.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

