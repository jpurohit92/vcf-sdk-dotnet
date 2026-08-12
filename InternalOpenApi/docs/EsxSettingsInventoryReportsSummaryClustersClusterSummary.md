# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryReportsSummaryClustersClusterSummary
The Esx.Settings.Inventory.Reports.Summary.Clusters.ClusterSummary schema contains information to summarize the operations performed on a cluster.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | Identifier of the cluster  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**SoftwareSpecInfo** | [**EsxSettingsInventoryReportsSummaryClustersSoftwareSpecInfo**](EsxSettingsInventoryReportsSummaryClustersSoftwareSpecInfo.md) | Information of the software specification from repository assigned to the cluster.  This property was added in __vSphere API 9.0.0.0__. | 
**ComplianceSummary** | [**EsxSettingsInventoryReportsSummaryClustersComplianceResult**](EsxSettingsInventoryReportsSummaryClustersComplianceResult.md) | Summary of the cluster compliance operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the cluster compliance operation is not requested. | [optional] 
**PrecheckSummary** | [**EsxSettingsInventoryReportsSummaryClustersPrecheckResult**](EsxSettingsInventoryReportsSummaryClustersPrecheckResult.md) | Summary of the cluster precheck operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the cluster precheck operation is not requested. | [optional] 
**StageSummary** | [**EsxSettingsInventoryReportsSummaryClustersStageResult**](EsxSettingsInventoryReportsSummaryClustersStageResult.md) | Summary of the cluster stage operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the cluster stage operation is not requested. | [optional] 
**ApplySummary** | [**EsxSettingsInventoryReportsSummaryClustersApplyResult**](EsxSettingsInventoryReportsSummaryClustersApplyResult.md) | Summary of the cluster apply operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the cluster apply operation is not requested. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

