# Vcenter.ViJson.OpenApi.Model.VsanClusterCreateShareSnapshotRequestType
The parameters of *VsanFileServiceSystem.VsanClusterCreateShareSnapshot*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**VsanFileShareSnapshotConfig**](VsanFileShareSnapshotConfig.md) | The snapshot configuration.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

