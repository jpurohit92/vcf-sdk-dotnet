# Vcenter.ViJson.OpenApi.Model.VsanCreateDatastoreSourceRequestType
The parameters of *VsanRemoteDatastoreSystem.VsanCreateDatastoreSource*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreSource** | [**VsanHciMeshDatastoreSource**](VsanHciMeshDatastoreSource.md) | The information of the Datastore Source to be created. If the vCenter is an ELM linked vCenter, only *VsanRemoteVcInfo.vcHost* needs to be specified. For a standalone vCenter, the *VsanRemoteVcInfoStandalone.user* and *VsanRemoteVcInfoStandalone.password* needs to be specified for an user credential with the privileges to create the service account.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

