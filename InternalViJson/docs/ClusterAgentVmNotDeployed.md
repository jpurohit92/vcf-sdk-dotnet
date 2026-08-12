# Vcenter.ViJson.OpenApi.Model.ClusterAgentVmNotDeployed
A cluster agent Virtual Machine is expected to be deployed on a cluster, but the cluster agent Virtual Machine has not been deployed or has been explicitly deleted from the cluster.  Typically more specific issue (a subclass of this issue) indicates the particular reason why vSphere ESX Agent Manager was unable to deploy the cluster agent Virtual Machine.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager redeploys the cluster agent Virtual Machine.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster for which this issue is raised.  Might be null if the cluster is missing in vCenter Server inventory.  Refers instance of *ComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

