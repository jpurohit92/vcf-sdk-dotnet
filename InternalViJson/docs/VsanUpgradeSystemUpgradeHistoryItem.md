# Vcenter.ViJson.OpenApi.Model.VsanUpgradeSystemUpgradeHistoryItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** | Time stamp when the history is record.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host a history item pertains to.  May be unset when item related to no particular host.  Refers instance of *HostSystem*.  | [optional] 
**Message** | **string** | Description of the history item.  | 
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | A task associated with the history item.  May be unset if no task is associated.  Refers instance of *Task*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

