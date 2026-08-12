# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareCheckSpec
The Esx.Settings.Repository.Software.CheckSpec schema contains properties used to check if a matching software specification is found in the repository. For a software specification in the repository to be considered a match, it has to match one of the fields.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The displayName to check in the repository.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, display names are not checked. | [optional] 
**SoftwareSpec** | [**EsxSettingsSoftwareSpec**](EsxSettingsSoftwareSpec.md) | The software spec to check in the repository.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, software specs are not checked. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

