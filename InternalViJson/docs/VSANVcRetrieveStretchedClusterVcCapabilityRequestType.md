# Vcenter.ViJson.OpenApi.Model.VSANVcRetrieveStretchedClusterVcCapabilityRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.VSANVcRetrieveStretchedClusterVcCapability*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster to query;  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**VerifyAllConnected** | **bool** | Whether to ignore disconnected hosts. If it is set to true, vim.fault.InvalidState will be met if any host in target cluster is disconnected; if it is set to false, disconnected hosts will be ignored. Default value is false. But a cluster with disconnected hosts cannot be converted to vSAN stretched cluster;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

