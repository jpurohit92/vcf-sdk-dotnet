# Vcenter.ViJson.OpenApi.Model.AgentRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The health of the managed entity.  This denotes how well the entity conforms to the goal state.  See also *EamObjectRuntimeInfoStatus_enum*.  | 
**Issue** | [**List&lt;Issue&gt;**](Issue.md) | Current issues that have been detected for this entity.  Each issue can be remediated by invoking *EamObject.Resolve* or *EamObject.ResolveAll*.  | [optional] 
**GoalState** | **string** | The desired state of the entity.  See also *EamObjectRuntimeInfoGoalState_enum*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *Agent* or *Agency* with which this &lt;code&gt;RuntimeInfo&lt;/code&gt; object is associated.  Refers instance of *EamObject*.  | 
**VmPowerState** | **VirtualMachinePowerStateEnum** | Deprecated get that info calling the virtual machine VIM API.  The power state of an agent virtual machine.  | 
**ReceivingHeartBeat** | **bool** | Deprecated get that info calling the virtual machine VIM API.  True if the vSphere ESX Agent Manager is receiving heartbeats from the agent virtual machine.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent host.  Refers instance of *HostSystem*.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent virtual machine.  Refers instance of *VirtualMachine*.  | [optional] 
**VmIp** | **string** | Deprecated get that info calling the virtual machine VIM API.  The IP address of the agent virtual machine  | [optional] 
**VmName** | **string** | Deprecated get that info calling the virtual machine VIM API.  The name of the agent virtual machine.  | 
**EsxAgentResourcePool** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated in order to retrieve agent resource pool use VIM API.  The ESX agent resource pool in which the agent virtual machine resides.  Refers instance of *ResourcePool*.  | [optional] 
**EsxAgentFolder** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated in order to retrieve agent VM folder use VIM API.  The ESX agent folder in which the agent virtual machine resides.  Refers instance of *Folder*.  | [optional] 
**InstalledBulletin** | **List&lt;string&gt;** | Deprecated use *AgentRuntimeInfo.installedVibs* instead.  An optional array of IDs of installed bulletins for this agent.  | [optional] 
**InstalledVibs** | [**List&lt;VibVibInfo&gt;**](VibVibInfo.md) | Information about the installed vibs on the host.  | [optional] 
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agency this agent belongs to.  Refers instance of *Agency*.  | [optional] 
**VmHook** | [**AgentVmHook**](AgentVmHook.md) | Active VM hook.  If present agent is actively waiting for *Agent.MarkAsAvailable*. See *AgentVmHook*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

