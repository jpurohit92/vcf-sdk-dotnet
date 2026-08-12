# Vcenter.ViJson.OpenApi.Model.MountPrecheckRequestType
The parameters of *VsanRemoteDatastoreSystem.MountPrecheck*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Client cluster that triggers the mount precheck request.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The server vSAN datastore to be checked for mount.  Refers instance of *Datastore*.  | 
**ServerClusterInfo** | [**VcRemoteVsanServerClusterInfo**](VcRemoteVsanServerClusterInfo.md) | The server cluster information of the vSAN datastore to be checked for mount. It&#39;s used for stretched cluster and remote data-in-transit configuration check.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

