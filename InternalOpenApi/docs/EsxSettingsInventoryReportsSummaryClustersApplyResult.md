# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryReportsSummaryClustersApplyResult
The Esx.Settings.Inventory.Reports.Summary.Clusters.ApplyResult schema contains properties that describe the result of an apply operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskStatus** | **string** | Provides the status of the apply task.  Possible values:   - &#x60;PENDING&#x60;: The operation is not performed yet.   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;CANCELED&#x60;: The operation is canceled.   - &#x60;SUCCEEDED&#x60;: The operation indicates a success.   - &#x60;FAILED&#x60;: The operation encountered an unspecified error.   - &#x60;SKIPPED&#x60;: The operation was skipped.   - &#x60;UNKNOWN&#x60;: The operation is in an unknown state.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Esx.Settings.Inventory.Reports.Summary.Clusters.TaskStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**ApplyStatus** | **string** | Specifies the aggregated status of the apply operation.  Possible values:   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;OK&#x60;: The operation completed successfully.   - &#x60;SKIPPED&#x60;: The operation was skipped.   - &#x60;TIMED_OUT&#x60;: The operation timed out.   - &#x60;ERROR&#x60;: The operation encountered an unspecified error.   - &#x60;RETRY_PENDING&#x60;: The operation is being scheduled for retry.   - &#x60;UNKNOWN&#x60;: The operation is in an unknown state.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Esx.Settings.Inventory.Reports.Summary.Clusters.ApplyStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**LastApplyTime** | **DateTime** | Time when the operation performed last time.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the operation has not been run yet. | [optional] 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications returned by the stage operation.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

