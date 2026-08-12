# Vcenter.ViJson.OpenApi.Model.VsanClusterRemoveShareSnapshotRequestType
The parameters of *VsanFileServiceSystem.VsanClusterRemoveShareSnapshot*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareUuid** | **string** | UUID of the file share to delete the snapshots.  | 
**SnapshotName** | **string** | Name of the snapshot to be deleted.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

