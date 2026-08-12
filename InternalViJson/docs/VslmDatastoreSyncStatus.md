# Vcenter.ViJson.OpenApi.Model.VslmDatastoreSyncStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreURL** | **string** | The datastore URL as specified in *DatastoreInfo.url*  | 
**ObjectVClock** | **long** |  | 
**SyncVClock** | **long** |  | 
**SyncTime** | **DateTime** | The time representing the last successful sync of the datastore.  | [optional] 
**NumberOfRetries** | **int** | The number of retries for the Datastore synchronization in failure cases.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | The fault is set in case of error conditions.  If the fault is set, the objectVClock and syncVClock will be set to -1L. Possible Faults: SyncFault If specified datastoreURL failed to sync.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

