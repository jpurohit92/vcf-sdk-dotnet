# Vcenter.ViJson.OpenApi.Model.ClusterAgentAgentIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agency to which this issue belongs.  Refers instance of *Agency*.  | 
**AgencyName** | **string** | The name of the agency.  | 
**SolutionId** | **string** | The ID of the solution to which this issue belongs.  | 
**SolutionName** | **string** | The name of the solution to which this issue belongs.  | 
**Agent** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agent that has this issue.  Refers instance of *Agent*.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster for which this issue is raised.  Might be null if the cluster is missing in vCenter Server inventory.  Refers instance of *ComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

