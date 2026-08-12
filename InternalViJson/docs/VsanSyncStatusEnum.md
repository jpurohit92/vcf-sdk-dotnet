# Vcenter.ViJson.OpenApi.Model.VsanSyncStatusEnum
The status of syncing vSAN component.  Components which need recovery can be in one of the three status.  Possible values: - `active`: The component which is actively syncing. - `queued`: The component which is in queue for sync to start.      Status change from queue to active could be due to reasons like availability of space in the cluster. - `suspended`: The component which is in suspended state.      This implies that once this component was actively syncing but now the sync is stopped by the cluster. Suspended state can be due to the disk on which component resides is close to full. - `VsanSyncStatus_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

