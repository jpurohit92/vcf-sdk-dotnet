# Vcenter.ViJson.OpenApi.Model.MoveDatastoreFileRequestType
The parameters of *FileManager.MoveDatastoreFile_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceName** | **string** | The name of the source, either a URL or a datastore path referring to the file or folder to be moved.  | 
**SourceDatacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;sourceName&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, &lt;code&gt;sourceName&lt;/code&gt; must be a URL.  ***Required privileges:*** System.View  Refers instance of *Datacenter*.  | [optional] 
**DestinationName** | **string** | The name of the destination, either a URL or a datastore path referring to the destination file or folder.  | 
**DestinationDatacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | If &lt;code&gt;destinationName&lt;/code&gt; is a datastore path, the datacenter for that datastore path. Not needed when invoked directly on ESX. If not specified on a call to VirtualCenter, it is assumed that the destination path belongs to the source datacenter.  ***Required privileges:*** System.View  Refers instance of *Datacenter*.  | [optional] 
**Force** | **bool** | If true, overwrite any identically named file at the destination. If not specified, it is assumed to be false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

