# Vcenter.Automation.OpenApi.Model.EsxSettingsCheckStatus
The Esx.Settings.CheckStatus schema contains properties that describe a check result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | [**EsxSettingsCheckDescription**](EsxSettingsCheckDescription.md) | Information about this check. | 
**Status** | **string** | The status of this check.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   - &#x60;RETRY&#x60;: The check failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health check before considering the check as failed.   For more information see: *Esx.Settings.Status*. | 
**Originator** | **string** | The service that performed the check. This field should allow easier triaging of health query errors.  Only set if there is an originator available for this check. | [optional] 
**Errors** | [**List&lt;EsxSettingsCheckError&gt;**](EsxSettingsCheckError.md) | List of *Esx.Settings.CheckError* that the check reported.  If not set, the service is still using the {#member issues}. TODO | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

