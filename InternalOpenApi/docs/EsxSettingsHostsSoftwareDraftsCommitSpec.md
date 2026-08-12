# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareDraftsCommitSpec
The Esx.Settings.Hosts.Software.Drafts.CommitSpec schema contains properties that are used to create a new commit.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Message to include with the commit.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, message is set to empty string. | [optional] 
**Orchestrator** | [**EsxSettingsOrchestratorSpec**](EsxSettingsOrchestratorSpec.md) | Orchestrator specification of the commit.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no orchestrator details is provided with the commit.   Note:   1. It is used by vLCM orchestrators like SDDC Manager to manage the desired state. For a non-orchestrator user i.e. a VC user, it must be unset.   2. Setting it prevents other users from modifying the committed desired state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

