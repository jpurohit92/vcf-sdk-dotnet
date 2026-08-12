# Vcenter.ViJson.OpenApi.Model.VsanClusterQueryShareSnapshotsRequestType
The parameters of *VsanFileServiceSystem.VsanClusterQueryShareSnapshots*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuerySpec** | [**VsanFileShareSnapshotQuerySpec**](VsanFileShareSnapshotQuerySpec.md) | The specification of the snapshots to be queried.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

