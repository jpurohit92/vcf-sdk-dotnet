# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareCheckStatus
The Esx.Settings.Hosts.Software.CheckStatus schema contains properties that describe a check result.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | [**EsxSettingsHostsSoftwareCheckInfo**](EsxSettingsHostsSoftwareCheckInfo.md) | Information about this check.  This property was added in __vSphere API 8.0.0.1__. | 
**Status** | **string** | The status of this check.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   - &#x60;RETRY&#x60;: The check failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health check before considering the check as failed.   For more information see: *Esx.Settings.Hosts.Software.Status*.  This property was added in __vSphere API 8.0.0.1__. | 
**CheckIssues** | [**List&lt;EsxSettingsHostsSoftwareCheckIssue&gt;**](EsxSettingsHostsSoftwareCheckIssue.md) | List of *Esx.Settings.Hosts.Software.CheckIssue*s that the check reported.  This property was added in __vSphere API 8.0.0.1__.  If not set, the service is still using the {#member issues}. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

