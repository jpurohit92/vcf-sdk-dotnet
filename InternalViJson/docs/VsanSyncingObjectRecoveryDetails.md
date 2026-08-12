# Vcenter.ViJson.OpenApi.Model.VsanSyncingObjectRecoveryDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivelySyncingObjectRecoveryETA** | **long** | It calculates the estimated time in seconds to recover objects actively syncing.  | [optional] 
**QueuedForSyncObjectRecoveryETA** | **long** | The estimated time in seconds to recover objects which are in queue and sync/recovery has not been started for the objects.  This includes time in wait queue and required to finish the sync.  | [optional] 
**SuspendedObjectRecoveryETA** | **long** | The estimated time in seconds to recover objects which are in suspended state.  Suspended object ETA is predicted based on the current syncing bandwidth and it can vary.  | [optional] 
**ActiveObjectsToSync** | **long** | The number of objects that are actively syncing.  | [optional] 
**QueuedObjectsToSync** | **long** | The number of objects which are in queue and for which the sync has not been started yet.  | [optional] 
**SuspendedObjectsToSync** | **long** | The number of objects which are in suspended state.  | [optional] 
**BytesToSyncForActiveObjects** | **long** | The amount of data in bytes to be synced for the objects which are actively syncing.  | [optional] 
**BytesToSyncForQueuedObjects** | **long** | The amount of data in bytes to be synced for the objects which are in queue and for which the sync has not been started yet.  | [optional] 
**BytesToSyncForSuspendedObjects** | **long** | The amount of data in bytes to be synced for the objects which are in suspended state.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

