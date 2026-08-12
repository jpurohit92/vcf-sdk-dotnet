# Vcenter.ViJson.OpenApi.Model.ManagedHostNotReachable
Managed ESXi Server is unreachable from vCenter Server or vSphere ESX Agent Manager.  Currently all operations on the affected host are impossible. Reasons for this might be : - ESXi Server is not connected from vCenter Server - ESXi Server powered off    This is not a remediable issue. To remediate, connect, power on or reboot the host.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**AgentName** | **string** | The name of the agent.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object reference to the host on which this agent is located.  Refers instance of *HostSystem*.  | 
**HostName** | **string** | The name of the host on which this agent is located.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

