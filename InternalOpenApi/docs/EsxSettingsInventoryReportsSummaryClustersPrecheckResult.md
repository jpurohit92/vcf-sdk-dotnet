# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryReportsSummaryClustersPrecheckResult
The Esx.Settings.Inventory.Reports.Summary.Clusters.PrecheckResult schema contains properties that describe aggregated status of all prechecks performed.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskStatus** | **string** | Provides the status of the precheck task.  Possible values:   - &#x60;PENDING&#x60;: The operation is not performed yet.   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;CANCELED&#x60;: The operation is canceled.   - &#x60;SUCCEEDED&#x60;: The operation indicates a success.   - &#x60;FAILED&#x60;: The operation encountered an unspecified error.   - &#x60;SKIPPED&#x60;: The operation was skipped.   - &#x60;UNKNOWN&#x60;: The operation is in an unknown state.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Esx.Settings.Inventory.Reports.Summary.Clusters.TaskStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**PrecheckStatus** | **string** | Aggregated status from all prechecks performed.  Possible values:   - &#x60;OK&#x60;: The precheck indicates a success.   - &#x60;WARNING&#x60;: The precheck indicates a warning.   - &#x60;TIMEOUT&#x60;: The precheck did not return in a timely manner.   - &#x60;ERROR&#x60;: The precheck indicates an error.   - &#x60;RETRY&#x60;: The precheck failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health precheck before considering the precheck as failed.   - &#x60;UNKNOWN&#x60;: The precheck is in an unknown state.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Esx.Settings.Inventory.Reports.Summary.Clusters.PrecheckStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**LastPrecheckTime** | **DateTime** | Time when the operation performed last time.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the operation has not been run yet. | [optional] 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications returned by the stage operation.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

