# Vcenter.ViJson.OpenApi.Model.VsanSnapshotSpace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SnapshotCount** | **int** | The total count of snapshots of all objects in cluster.  | [optional] 
**ActualSnapshotUsedB** | **long** | The actual written snapshot capacity in cluster excluding RAID overhead and file system usage.  | [optional] 
**FullyInflatedSnapshotUsedB** | **long** | Fully inflated snapshot capacity in bytes.  It refers to the total storage that would be consumed if all snapshots occupied their full logical size, without benefiting from any space efficiency mechanisms such as native snapshot or deduplication.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

