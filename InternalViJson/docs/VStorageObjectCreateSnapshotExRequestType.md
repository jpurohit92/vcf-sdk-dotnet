# Vcenter.ViJson.OpenApi.Model.VStorageObjectCreateSnapshotExRequestType
The parameters of *VStorageObjectManagerBase.VStorageObjectCreateSnapshotEx_Task*.  ***Since:*** vSphere API Release 8.0.2.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the source virtual storage object is located.  Refers instance of *Datastore*.  | 
**Description** | **string** | A short description to be associated with the snapshot.  | 
**SnapshotId** | [**ID**](ID.md) | The ID of the snapshot of the virtual storage object, For each new request, the ID should be a unique ID complying to RFC4122V4 (generated randomly). For retry requests with the same ID, all the other input parameters are expected to remain same. If not specified, a random system generated snapshot ID will be assigned to the snapshot.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

