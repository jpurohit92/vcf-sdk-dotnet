# Vcenter.ViJson.OpenApi.Model.RemoveAllSnapshotsRequestType
The parameters of *VirtualMachine.RemoveAllSnapshots_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Consolidate** | **bool** | (optional) If set to true, the virtual disks of the deleted snapshot will be merged with other disk if possible. Default to true.  | [optional] 
**Spec** | [**SnapshotSelectionSpec**](SnapshotSelectionSpec.md) | (optional) When provided, only snapshots satisfying the criteria described by the spec will be removed. If unset, all snapshots will be removed.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

