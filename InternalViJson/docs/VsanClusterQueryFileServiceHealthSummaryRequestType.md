# Vcenter.ViJson.OpenApi.Model.VsanClusterQueryFileServiceHealthSummaryRequestType
The parameters of *VsanVcClusterHealthSystem.VsanClusterQueryFileServiceHealthSummary*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**IncludeFileServerHealth** | **bool** | Whether to retrieve file server health, default value is True.  | [optional] 
**IncludeFileShareHealth** | **bool** | Whether to retrieve file share health, default value is True.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

