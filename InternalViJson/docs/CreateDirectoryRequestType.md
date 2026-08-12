# Vcenter.ViJson.OpenApi.Model.CreateDirectoryRequestType
The parameters of *DatastoreNamespaceManager.CreateDirectory*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | datastore on which to create a top-level directory  ***Required privileges:*** Datastore.Config  Refers instance of *Datastore*.  | 
**DisplayName** | **string** | display name hint for the directory to create  | [optional] 
**Policy** | **string** | opaque storage policy to associate with the directory  | [optional] 
**Size** | **long** | directory size in MB on vvol/vsan backed object storage. default directory size will be used for vsan backed object storage if not set.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

