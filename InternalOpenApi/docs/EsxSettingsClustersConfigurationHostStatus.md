# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationHostStatus
The Esx.Settings.Clusters.Configuration.HostStatus schema contains properties that describe the status of an operation.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the operation.  Possible values:   - &#x60;OK&#x60;: The operation completed successfully.   - &#x60;PENDING&#x60;: The operation is pending.   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;RETRY_PENDING&#x60;: The operation is pending a retry.   - &#x60;SKIPPED&#x60;: The operation was skipped.   - &#x60;CANCELED&#x60;: The operation was canceled.   - &#x60;TIMED_OUT&#x60;: The operation timed out.   - &#x60;ERROR&#x60;: The operation encountered an unspecified error.   For more information see: *Esx.Settings.Clusters.Configuration.HostStatus.Status*.  This property was added in __vSphere API 8.0.1.0__. | 
**Attempts** | **long** | Number of the performed attempts of the operation.  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; if it is not applicable. | [optional] 
**RemainingRetries** | **long** | Number of the remaining attempts of the operation.  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; if it is not applicable. | [optional] 
**StartTime** | **DateTime** | Time when the operation started.  This property was added in __vSphere API 8.0.1.0__. | 
**EndTime** | **DateTime** | Time when the operation completed.  This property was added in __vSphere API 8.0.1.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications providing additional information about the status of the operation.  This property was added in __vSphere API 8.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

