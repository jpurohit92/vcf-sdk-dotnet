# Vcenter.ViJson.OpenApi.Model.VsanQueryHciMeshDatastoresRequestType
The parameters of *VsanRemoteDatastoreSystem.VsanQueryHciMeshDatastores*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuerySpecs** | [**List&lt;VsanXvcQuerySpec&gt;**](VsanXvcQuerySpec.md) | The spec information to specify what to be queried.  | [optional] 
**ExtraVcInfos** | [**List&lt;VsanRemoteVcInfo&gt;**](VsanRemoteVcInfo.md) | The remote vCenter information for communication if caller needs to explicitly specify a remote vCenter as a provider vCenter which is not configured as a Datastore Source configuration. The user credential needs to be provided in the remote vCenter information, e.g., use *VsanRemoteVcInfoStandalone*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

