# Vcenter.Automation.OpenApi.Model.EsxSettingsStatusInfo
The Esx.Settings.StatusInfo schema contains properties that describe aggregated status of all checks performed on an entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Aggregated status from all checks performed on this entity.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   - &#x60;RETRY&#x60;: The check failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health check before considering the check as failed.   For more information see: *Esx.Settings.Status*. | 
**CheckStatuses** | [**List&lt;EsxSettingsCheckStatus&gt;**](EsxSettingsCheckStatus.md) | List of Esx.Settings.CheckStatus for all checks performed. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

