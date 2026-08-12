# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareDraftsCommitSpec
The Esx.Settings.Repository.Software.Drafts.CommitSpec schema contains properties that are used to create a new commit in the repository.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Message to include with the commit. The message is saved as part of the software specification&#39;s history.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, message is set to empty string. | [optional] 
**Orchestrator** | [**EsxSettingsOrchestratorSpec**](EsxSettingsOrchestratorSpec.md) | Orchestrator specification of the commit.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no orchestrator details is provided with the commit.   Note:   1. It is used by vLCM orchestrators like SDDC Manager to manage the desired state. For a non-orchestrator user i.e. a VC user, it must be unset.   2. Setting it prevents other users from modifying the committed desired state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

