# Vcenter.ViJson.OpenApi.Model.MissingDvFilterSwitch
Deprecated dvFilters are no longer supported by EAM.  The agent is using the dvFilter API on the ESX host, but no dvFilter switch has been configured on the host.  This can happen due to host communication failures or if the dvSwitch was (presumably accidentally) deleted from the host configuration.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager recreates the dvFilter switch.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**AgentName** | **string** | The name of the agent.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object reference to the host on which this agent is located.  Refers instance of *HostSystem*.  | 
**HostName** | **string** | The name of the host on which this agent is located.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

