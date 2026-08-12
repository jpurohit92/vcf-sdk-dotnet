# Vcenter.ViJson.OpenApi.Model.HostUpdateVStorageObjectMetadataRequestType
The parameters of *HostVStorageObjectManager.HostUpdateVStorageObjectMetadata_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore to query for the virtual storage objects.  Refers instance of *Datastore*.  | 
**Metadata** | [**List&lt;KeyValue&gt;**](KeyValue.md) | array of key/value strings. (keys must be unique within the list)  | [optional] 
**DeleteKeys** | **List&lt;string&gt;** | array of keys need to be deleted  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

