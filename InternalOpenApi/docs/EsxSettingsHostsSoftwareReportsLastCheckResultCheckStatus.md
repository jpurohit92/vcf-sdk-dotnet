# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareReportsLastCheckResultCheckStatus
The Esx.Settings.Hosts.Software.Reports.LastCheckResult.CheckStatus schema contains properties that describe a check result.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | [**EsxSettingsHostsSoftwareReportsLastCheckResultCheckInfo**](EsxSettingsHostsSoftwareReportsLastCheckResultCheckInfo.md) | Information about this check.  This property was added in __vSphere API 8.0.0.1__. | 
**Status** | **string** | The status of this check.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   For more information see: *Esx.Settings.Hosts.Software.Reports.LastCheckResult.Status*.  This property was added in __vSphere API 8.0.0.1__. | 
**CheckIssues** | [**List&lt;EsxSettingsHostsSoftwareReportsLastCheckResultCheckIssue&gt;**](EsxSettingsHostsSoftwareReportsLastCheckResultCheckIssue.md) | The issues encountered while running this check.  This property was added in __vSphere API 8.0.0.1__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

