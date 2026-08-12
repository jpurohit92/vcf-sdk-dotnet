# Vcenter.ViJson.OpenApi.Model.TransitionFailed
An agent failed to be transitioned to a LCCM Solution.  This is an active remediable issue. To remediate, resolve the issue via vLCM System VMs API  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 9.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**AgentName** | **string** | The name of the agent.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object reference to the host on which this agent is located.  Refers instance of *HostSystem*.  | 
**HostName** | **string** | The name of the host on which this agent is located.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

