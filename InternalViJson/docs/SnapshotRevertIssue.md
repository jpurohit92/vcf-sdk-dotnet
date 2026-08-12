# Vcenter.ViJson.OpenApi.Model.SnapshotRevertIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SnapshotName** | **string** | The name of the problematic snapshot.  | [optional] 
**Event** | [**List&lt;Event&gt;**](Event.md) | The problem(s) that would occur on reverting to the snapshot.  This is determined similarly to invoking validateMigration on a powered-off virtual machine with the snapshot&#39;s state. However, not all errors or warnings for virtual machine migration are guaranteed to be detected for snapshots.  | [optional] 
**Errors** | **bool** | True if any of the events above are error events.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

