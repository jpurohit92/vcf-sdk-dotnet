# Vcenter.ViJson.OpenApi.Model.QueryVmfsDatastoreExtendOptionsRequestType
The parameters of *HostDatastoreSystem.QueryVmfsDatastoreExtendOptions*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore to be extended.  Refers instance of *Datastore*.  | 
**DevicePath** | **string** | The devicePath of the disk on which datastore extension options are generated.  | 
**SuppressExpandCandidates** | **bool** | Indicates whether to exclude options that can be used for extent expansion also. Free space can be used for adding an extent or expanding an existing extent. If this parameter is set to true, the list of options returned will not include free space that can be used for expansion.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

