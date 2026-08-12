# Vcenter.ViJson.OpenApi.Model.HostDeleteVStorageObjectExRequestType
The parameters of *HostVStorageObjectManager.HostDeleteVStorageObjectEx_Task*.  ***Since:*** vSphere API Release 7.0.2.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object to be deleted.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the virtual storage object is located.  Refers instance of *Datastore*.  | 
**IsLcParentAttached** | **bool** | Set to true if parent of linked clone is attached to VM, set to false if parent of linked clone is detached, unset is considered as false.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

