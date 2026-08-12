# Vcenter.ViJson.OpenApi.Model.CnsSyncVolumeSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier for the volume.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Optional Datastore object where the volume belongs.  This field identifies the datastore associated with the volume that needs to be synchronized. This field is useful when CNS does not have information about datastore or to optimize additional synchronization process by directing it to a specific datastore.  Refers instance of *Datastore*.  | [optional] 
**SyncMode** | **List&lt;string&gt;** | Array of supported synchronization mode specifying what information to be synchronize.  This field provides more control over the synchronisation process. For instance, if configured to synchronise only space usage, the operation will update only those details, not all volume properties. One or more such modes can be passed. If none are passed, it will be a full synchronisation. The possible values for this field are enumerated in *CnsSyncVolumeMode_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

