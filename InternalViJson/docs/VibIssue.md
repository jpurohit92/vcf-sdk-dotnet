# Vcenter.ViJson.OpenApi.Model.VibIssue
Deprecated as of vSphere 9.0. Please refer to vLCM Image APIs.  Base class for all issues related to the VIB modules that belong to an agent.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**AgentName** | **string** | The name of the agent.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object reference to the host on which this agent is located.  Refers instance of *HostSystem*.  | 
**HostName** | **string** | The name of the host on which this agent is located.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

