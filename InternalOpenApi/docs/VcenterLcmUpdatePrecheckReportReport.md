# Vcenter.Automation.OpenApi.Model.VcenterLcmUpdatePrecheckReportReport
The Vcenter.Lcm.Update.PrecheckReport.Report schema contains estimates of how long it will take an update as well as a list of possible warnings and errors with applying the update.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateCreated** | **DateTime** | Time when this precheck report was generated | 
**EstimatedTimeToUpdate** | **long** | Rough estimate of time to update vCenter Server in minutes.  This property will be missing or &#x60;null&#x60; if the precheck failed. | [optional] 
**Issues** | [**VcenterLcmNotifications**](VcenterLcmNotifications.md) | Lists of the issues and warnings  This property will be missing or &#x60;null&#x60; if the precehck is successful. | [optional] 
**Summary** | [**VcenterLcmUpdatePrecheckReportReportSummary**](VcenterLcmUpdatePrecheckReportReportSummary.md) | A summary of the report consist of count of warnings and errors returned by running the precheck. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

