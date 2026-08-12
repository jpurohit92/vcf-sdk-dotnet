# Vcenter.ViJson.OpenApi.Model.ConvertNamespacePathToUuidPathRequestType
The parameters of *DatastoreNamespaceManager.ConvertNamespacePathToUuidPath*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datacenter of the namespace path. Needs to be set when making the call to VC; ignored when the call is made to ESX.  Refers instance of *Datacenter*.  | [optional] 
**NamespaceUrl** | **string** | Namespace URL of the form &gt; \\[ds://\\]/vmfs/volumes/\\[_datastore-uuid_\\]/\\[_directory-name_\\]/... &gt;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

