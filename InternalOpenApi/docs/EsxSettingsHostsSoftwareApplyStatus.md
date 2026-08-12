# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareApplyStatus
The Esx.Settings.Hosts.Software.ApplyStatus schema contains properties that describe the status of an *POST /esx/settings/hosts/{host}/software?action=apply* operation.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the operation.  Possible values:   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;OK&#x60;: The operation completed successfully.   - &#x60;SKIPPED&#x60;: The operation was skipped.   - &#x60;TIMED_OUT&#x60;: The operation timed out.   - &#x60;ERROR&#x60;: The operation encountered an unspecified error.   - &#x60;RETRY_PENDING&#x60;: The operation is being scheduled for retry.   For more information see: *Esx.Settings.Hosts.Software.ApplyStatus.Status*.  This property was added in __vSphere API 8.0.0.1__. | 
**Progress** | [**CisTaskProgress**](CisTaskProgress.md) | Progress of the operation.  This property was added in __vSphere API 8.0.0.1__.  missing or &#x60;null&#x60; for host ApplyStatus | [optional] 
**StartTime** | **DateTime** | Time when the operation started.  This property was added in __vSphere API 8.0.0.1__. | 
**EndTime** | **DateTime** | Time when the operation completed.  This property was added in __vSphere API 8.0.0.1__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications providing additional information about the status of the operation.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

