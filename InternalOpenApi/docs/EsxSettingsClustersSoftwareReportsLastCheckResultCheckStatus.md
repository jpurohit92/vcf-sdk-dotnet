# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsLastCheckResultCheckStatus
The Esx.Settings.Clusters.Software.Reports.LastCheckResult.CheckStatus schema contains properties that describe a check result.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | [**EsxSettingsClustersSoftwareReportsLastCheckResultCheckInfo**](EsxSettingsClustersSoftwareReportsLastCheckResultCheckInfo.md) | Information about this check.  This property was added in __vSphere API 7.0.0.0__. | 
**Status** | **string** | The status of this check.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   For more information see: *Esx.Settings.Clusters.Software.Reports.LastCheckResult.Status*.  This property was added in __vSphere API 7.0.0.0__. | 
**Issues** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | The issues encountered while running this check.    Note: This property will be deprecated in the future release. Clients are recommended to use {#member checkIssues} field.  This property was added in __vSphere API 7.0.0.0__. | 
**CheckIssues** | [**List&lt;EsxSettingsClustersSoftwareReportsLastCheckResultCheckIssue&gt;**](EsxSettingsClustersSoftwareReportsLastCheckResultCheckIssue.md) | List of *Esx.Settings.Clusters.Software.Reports.LastCheckResult.CheckIssue*s that the check reported.  This property was added in __vSphere API 9.1.0.0__.  If not set, the service is still using the {#member issues}. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

