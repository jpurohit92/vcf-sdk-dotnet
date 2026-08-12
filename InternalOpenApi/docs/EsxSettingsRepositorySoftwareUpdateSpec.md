# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareUpdateSpec
The Esx.Settings.Repository.Software.UpdateSpec schema defines the information used to update a software specification in the repository.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the software specification. Supported encoding is UTF-8.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the display name is not updated. | [optional] 
**Orchestrator** | [**EsxSettingsOrchestratorSpec**](EsxSettingsOrchestratorSpec.md) | Orchestrator specification of the software specification in The repository.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no orchestrator details is provided with the commit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

