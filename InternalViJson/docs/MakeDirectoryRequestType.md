# Vcenter.ViJson.OpenApi.Model.MakeDirectoryRequestType
The parameters of *FileManager.MakeDirectory*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the folder, either a URL or a datastore path referring to the folder to be created.  | 
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;name&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;name&lt;/code&gt; must be a URL.  ***Required privileges:*** System.View  Refers instance of *Datacenter*.  | [optional] 
**CreateParentDirectories** | **bool** | If true, any non-existent intermediate level folders will be created. If not specified, it is assumed to be false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

