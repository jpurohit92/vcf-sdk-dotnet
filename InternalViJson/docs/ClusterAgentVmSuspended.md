# Vcenter.ViJson.OpenApi.Model.ClusterAgentVmSuspended
A cluster agent Virtual Machine is expected to be powered on, but the agent Virtual Machine is suspended.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager powers on the cluster agent Virtual Machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

