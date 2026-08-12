# Vcenter.ViJson.OpenApi.Model.VsanHostVsanObjectSyncQueryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalObjectsToSync** | **long** | Total number of vSAN objects that are syncing.  It&#39;s returned only when summary data is needed.  | [optional] 
**TotalBytesToSync** | **long** | The amount of data to be re-synced.  It&#39;s returned only when summary data is needed.  | [optional] 
**TotalRecoveryETA** | **long** | The estimated time in seconds to recover all vSAN objects of specified types.  It&#39;s returned only when summary data is needed.  | [optional] 
**Objects** | [**List&lt;VsanHostVsanObjectSyncState&gt;**](VsanHostVsanObjectSyncState.md) | The retrieved objects.  | [optional] 
**SyncingObjectRecoveryDetails** | [**VsanSyncingObjectRecoveryDetails**](VsanSyncingObjectRecoveryDetails.md) | Details returned from querying vSAN syncing objects for different sync status.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

