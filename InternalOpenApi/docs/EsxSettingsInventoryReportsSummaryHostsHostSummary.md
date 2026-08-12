# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryReportsSummaryHostsHostSummary
The Esx.Settings.Inventory.Reports.Summary.Hosts.HostSummary schema contains information to summarize the operations performed on a standalone host.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Identifier of the standalone host.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**SoftwareSpecInfo** | [**EsxSettingsInventoryReportsSummaryHostsSoftwareSpecInfo**](EsxSettingsInventoryReportsSummaryHostsSoftwareSpecInfo.md) | Information of the software specification from repository assigned to the standalone host.  This property was added in __vSphere API 9.0.0.0__. | 
**ComplianceSummary** | [**EsxSettingsInventoryReportsSummaryHostsComplianceResult**](EsxSettingsInventoryReportsSummaryHostsComplianceResult.md) | Summary of the standalone host compliance operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the standalone host compliance operation is not requested. | [optional] 
**PrecheckSummary** | [**EsxSettingsInventoryReportsSummaryHostsPrecheckResult**](EsxSettingsInventoryReportsSummaryHostsPrecheckResult.md) | Summary of the standalone host precheck operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the standalone host precheck operation is not requested. | [optional] 
**StageSummary** | [**EsxSettingsInventoryReportsSummaryHostsStageResult**](EsxSettingsInventoryReportsSummaryHostsStageResult.md) | Summary of the standalone host stage operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the standalone host stage operation is not requested. | [optional] 
**ApplySummary** | [**EsxSettingsInventoryReportsSummaryHostsApplyResult**](EsxSettingsInventoryReportsSummaryHostsApplyResult.md) | Summary of the standalone host apply operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the standalone host apply operation is not requested. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

