# Vcenter.ViJson.OpenApi.Model.DeleteDirectoryRequestType
The parameters of *DatastoreNamespaceManager.DeleteDirectory*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datacenter of the datastore path. Needs to be set when making the call to VC; ignored when the call is made to ESX.  ***Required privileges:*** System.View  Refers instance of *Datacenter*.  | [optional] 
**DatastorePath** | **string** | Stable vmfs path of the directory to delete.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

