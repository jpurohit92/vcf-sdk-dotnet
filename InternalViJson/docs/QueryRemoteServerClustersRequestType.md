# Vcenter.ViJson.OpenApi.Model.QueryRemoteServerClustersRequestType
The parameters of *VsanPerformanceManager.QueryRemoteServerClusters*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Local vSAN cluster. This parameter will be ignored if the API is called against host.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 
**QuerySpec** | [**VsanRemoteClusterQuerySpec**](VsanRemoteClusterQuerySpec.md) | Specification for the query operation. If the parameter is not specified all available remote clusters will be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

