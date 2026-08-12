# Vcenter.ViJson.OpenApi.Model.HostRetrieveVStorageObjectRequestType
The parameters of *HostVStorageObjectManager.HostRetrieveVStorageObject*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object to be retrieved.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the virtual storage object is located.  Refers instance of *Datastore*.  | 
**DiskInfoFlags** | **List&lt;string&gt;** | Flags indicating the FCD information to be retrieved. If diskInfoFlags is unset, then all FCD information will be retrieved. See *vslmDiskInfoFlag_enum* for the list of supported values.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

