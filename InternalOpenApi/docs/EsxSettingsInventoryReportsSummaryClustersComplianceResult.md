# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryReportsSummaryClustersComplianceResult
The Esx.Settings.Inventory.Reports.Summary.Clusters.ComplianceResult schema contains properties to describe the compliance result of a cluster.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskStatus** | **string** | Provides the status of the compliance task.  Possible values:   - &#x60;PENDING&#x60;: The operation is not performed yet.   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;CANCELED&#x60;: The operation is canceled.   - &#x60;SUCCEEDED&#x60;: The operation indicates a success.   - &#x60;FAILED&#x60;: The operation encountered an unspecified error.   - &#x60;SKIPPED&#x60;: The operation was skipped.   - &#x60;UNKNOWN&#x60;: The operation is in an unknown state.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Esx.Settings.Inventory.Reports.Summary.Clusters.TaskStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**ComplianceStatus** | **string** | Overall compliance status of the cluster.  Possible values:   - &#x60;COMPLIANT&#x60;: Target version is same as current version.   - &#x60;NON_COMPLIANT&#x60;: Target version is greater than current version.   - &#x60;INCOMPATIBLE&#x60;: Target state cannot be applied due to conflict or missing dependencies or the target state is lesser than the current version.   - &#x60;UNAVAILABLE&#x60;: Drift check failed due to unknown error or check hasn&#39;t happened yet and results are not available.   For more information see: *Esx.Settings.ComplianceStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**LastComplianceTime** | **DateTime** | Time when the operation performed last time.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the operation has not been run yet. | [optional] 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications returned by the scan operation.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

