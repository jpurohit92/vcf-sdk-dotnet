# Vcenter.ViJson.OpenApi.Model.VsanAdvancedDatastoreConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastores** | [**List&lt;VsanDatastoreSpec&gt;**](VsanDatastoreSpec.md) | The list of non-default vSAN datastores.  | [optional] 
**RemoteDatastores** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The remote vSAN datastores to be mounted to target vSAN cluster, which are provided by other vSAN clusters.  All in use remote vSAN datastores of target vSAN cluster will be unmounted if this field is omitted.  Refers instances of *Datastore*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

