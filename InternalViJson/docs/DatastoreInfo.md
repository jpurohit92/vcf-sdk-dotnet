# Vcenter.ViJson.OpenApi.Model.DatastoreInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the datastore.  | 
**Url** | **string** | The unique locator for the datastore.  | 
**FreeSpace** | **long** | Free space of this datastore, in bytes.  The server periodically updates this value. It can be explicitly refreshed with the Refresh operation.  | 
**MaxFileSize** | **long** | The maximum size of a file that can reside on this file system volume.  | 
**MaxVirtualDiskCapacity** | **long** | The maximum capacity of a virtual disk which can be created on this volume.  | [optional] 
**MaxMemoryFileSize** | **long** | The maximum size of a snapshot or a swap file that can reside on this file system volume.  | 
**Timestamp** | **DateTime** | Time when the free-space and capacity values in *DatastoreInfo* and *DatastoreSummary* were updated.  | [optional] 
**ContainerId** | **string** | The unique container ID of the datastore, if applicable.  | [optional] 
**AliasOf** | **string** | vSAN datastore container that this datastore is alias of.  If this field is unset then this datastore is not alias of any other vSAN datastore. See *DatastoreInfo.containerId*.  | [optional] 
**SupportedVDiskFormats** | **List&lt;string&gt;** | A list of virtual disk format type which can be supported on that datastore.  Supported values are *native_512* and *native_4k*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**LogicalSectorSize** | **int** | The logical sector size of the datastore.  If not set, the default is 512 bytes.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**PhysicalSectorSize** | **int** | The physical sector size of the datastore.  If not set, the default is 512 bytes.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

