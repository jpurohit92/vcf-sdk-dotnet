# Vcenter.ViJson.OpenApi.Model.HostRetrieveVStorageObjectMetadataRequestType
The parameters of *HostVStorageObjectManager.HostRetrieveVStorageObjectMetadata*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore to query for the virtual storage objects.  Refers instance of *Datastore*.  | 
**SnapshotId** | [**ID**](ID.md) | The ID of the snapshot of virtual storage object.  | [optional] 
**Prefix** | **string** | The prefix of the metadata key that needs to be retrieved  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

