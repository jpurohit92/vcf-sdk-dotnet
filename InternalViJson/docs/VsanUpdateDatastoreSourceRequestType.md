# Vcenter.ViJson.OpenApi.Model.VsanUpdateDatastoreSourceRequestType
The parameters of *VsanRemoteDatastoreSystem.VsanUpdateDatastoreSource*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreSource** | [**VsanHciMeshDatastoreSource**](VsanHciMeshDatastoreSource.md) | The information of the Datastore Source to be updated. The updated Datastore Source is identified by the vcHost specified in the remote vCenter info of this param. If the original or updated vCenter is a standalone vCenter, the *VsanRemoteVcInfoStandalone.user* and *VsanRemoteVcInfoStandalone.password* needs to be specified for an user credential with the privilege to update the service account. If both original and updated vCenters are ELM vCenters only *VsanRemoteVcInfo.vcHost* needs to be specified.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

