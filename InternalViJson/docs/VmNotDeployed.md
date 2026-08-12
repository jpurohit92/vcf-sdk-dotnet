# Vcenter.ViJson.OpenApi.Model.VmNotDeployed
An agent virtual machine is expected to be deployed on a host, but the agent virtual machine has not been deployed.  Typically, a more specific issue (a subclass of this issue) indicates the particular reason why vSphere ESX Agent Manager was unable to deploy the agent, such as being unable to access the OVF package for the agent or a missing host configuration. This issue can also happen if the agent virtual machine is explicitly deleted from the host.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager redeploys the agent virtual machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**AgentName** | **string** | The name of the agent.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object reference to the host on which this agent is located.  Refers instance of *HostSystem*.  | 
**HostName** | **string** | The name of the host on which this agent is located.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

