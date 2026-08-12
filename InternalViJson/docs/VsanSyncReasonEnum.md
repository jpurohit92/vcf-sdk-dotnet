# Vcenter.ViJson.OpenApi.Model.VsanSyncReasonEnum
The reasons why a vSAN component went into syncing state.  Possible values: - `repair`: The component is created and resyncing to repair a bad component. - `evacuate`: The component is created and resyncing after evacuate disk group or host to ensure accessibility and full data evacuation. - `rebalance`: The component is created and resyncing for rebalancing. - `reconfigure`: The component is created and resyncing after vSAN object was resized or its policy was changed. - `dying_evacuate`: The component is being moved out when a disk is going to die. - `stale`: The component is syncing because it was stale. - `merge_concat`: The component is created and resyncing to merge concatenations. - `object_format_change` - `VsanSyncReason_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

