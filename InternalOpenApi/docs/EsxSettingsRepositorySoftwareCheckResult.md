# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareCheckResult
The Esx.Settings.Repository.Software.CheckResult schema contains properties that describe the result of a check for a software specification in the repository. see *POST /esx/settings/repository/software?action=check-repository*  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Matches** | [**List&lt;EsxSettingsRepositorySoftwareMatchResult&gt;**](EsxSettingsRepositorySoftwareMatchResult.md) | The type of match and the summary of one or more software specification in the repository if the check found a match. If the list is empty, a match was not found for the inputs specified by the user.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

