# Vcenter.ViJson.OpenApi.Model.VsanClusterRemoveShareRequestType
The parameters of *VsanFileServiceSystem.VsanClusterRemoveShare*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareUuid** | **string** | The UUID of the file share to be removed.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 
**Force** | **bool** | The force flag is to force the removal of a vSphere managed file share, for example, the file share managed by Cloud Native Storage (CNS) service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

