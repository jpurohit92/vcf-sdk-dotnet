# Vcenter.ViJson.OpenApi.Model.ClusterAgentTransitionFailed
A cluster agent failed to be transitioned to a LCCM Solution.  This is an active remediable issue. To remediate, resolve the issue via vLCM System VMs API  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 9.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster for which this issue is raised.  Might be null if the cluster is missing in vCenter Server inventory.  Refers instance of *ComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

