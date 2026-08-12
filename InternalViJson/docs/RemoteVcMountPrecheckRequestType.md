# Vcenter.ViJson.OpenApi.Model.RemoteVcMountPrecheckRequestType
The parameters of *VsanRemoteDatastoreSystem.RemoteVcMountPrecheck*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Client cluster that trigger the mount precheck request.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**XvcDatastore** | [**VsanXVCDatastoreInfo**](VsanXVCDatastoreInfo.md) |  | 
**ServerClusterInfo** | [**VcRemoteVsanServerClusterInfo**](VcRemoteVsanServerClusterInfo.md) | Server cluster information of the remote VC vSAN datastore to be checked for mount.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

