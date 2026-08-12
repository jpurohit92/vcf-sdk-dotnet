# Vcenter.ViJson.OpenApi.Model.VslmVsoVStorageObjectResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ID**](ID.md) | The ID of the virtual storage object.  | 
**Name** | **string** | Name of FCD.  | [optional] 
**CapacityInMB** | **long** | The size in MB of this object.  If the faults are set, then the capacityInMB will be -1  | 
**CreateTime** | **DateTime** | The create time information of the FCD.  | [optional] 
**DatastoreUrl** | **string** | The Datastore URL containing the FCD.  | [optional] 
**DiskPath** | **string** | The disk path of the FCD.  | [optional] 
**UsedCapacityInMB** | **long** | The rolled up used capacity of the FCD and it&#39;s snapshots.  Returns -1L if the space information is currently unavailable.  | [optional] 
**BackingObjectId** | [**ID**](ID.md) | The ID of the backing object of the virtual storage object.  | [optional] 
**SnapshotInfo** | [**List&lt;VslmVsoVStorageObjectSnapshotResult&gt;**](VslmVsoVStorageObjectSnapshotResult.md) | VStorageObjectSnapshotResult array containing information about all the snapshots of the virtual storage object.  | [optional] 
**Metadata** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Metadata array of key/value strings.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | The fault is set in case of error conditions and this property will have the reason.  Possible Faults: NotFound If specified virtual storage object cannot be found.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

