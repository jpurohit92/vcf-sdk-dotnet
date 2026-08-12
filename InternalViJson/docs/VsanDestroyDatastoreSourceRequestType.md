# Vcenter.ViJson.OpenApi.Model.VsanDestroyDatastoreSourceRequestType
The parameters of *VsanRemoteDatastoreSystem.VsanDestroyDatastoreSource*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreSource** | [**VsanHciMeshDatastoreSource**](VsanHciMeshDatastoreSource.md) | The Datastore Source to be destroyed. If the vCenter is an ELM linked vCenter, only *VsanRemoteVcInfo.vcHost* needs to be specified. For a standalone vCenter, the *VsanRemoteVcInfoStandalone.user* and *VsanRemoteVcInfoStandalone.password* needs to be specified for an user credential with the privileges to delete the service account.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

