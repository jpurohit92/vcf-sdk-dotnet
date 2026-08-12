# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareMatchResult
The Esx.Settings.Repository.Software.MatchResult contains the result for one matching software specification.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchTypes** | **List&lt;string&gt;** | The types of matches.  Possible values:   - &#x60;NAME_MATCH&#x60;: The status indicates a software specification matching the name in the user input was found.   - &#x60;SOFTWARE_SPEC_MATCH&#x60;: The status indicates a software specification matching the spec in the user input was found.   For more information see: *Esx.Settings.Repository.Software.MatchResult.MatchType*.  This property was added in __vSphere API 9.0.0.0__. | 
**Record** | [**EsxSettingsRepositorySoftwareRecord**](EsxSettingsRepositorySoftwareRecord.md) | The summary of the software specification that matched the user input.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

