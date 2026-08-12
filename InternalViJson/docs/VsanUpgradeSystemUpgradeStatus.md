# Vcenter.ViJson.OpenApi.Model.VsanUpgradeSystemUpgradeStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InProgress** | **bool** | True if there is an active upgrade process.  If true, other fields are guaranteed to be populated. If false, other fields may reflect a previous upgrade process run, or they may be unset.  | 
**History** | [**List&lt;VsanUpgradeSystemUpgradeHistoryItem&gt;**](VsanUpgradeSystemUpgradeHistoryItem.md) | Log of a single upgrade task.  Lists all operations performed by the upgrade process in chronological order.  | [optional] 
**Aborted** | **bool** | Set if the upgrade process was aborted.  | [optional] 
**Completed** | **bool** | Set if the upgrade process has completed successfully.  | [optional] 
**Progress** | **int** | Progress in percent.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

