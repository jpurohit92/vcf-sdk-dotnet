# Vcenter.ViJson.OpenApi.Model.ClusterAgentVmIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster for which this issue is raised.  Might be null if the cluster is missing in vCenter Server inventory.  Refers instance of *ComputeResource*.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

