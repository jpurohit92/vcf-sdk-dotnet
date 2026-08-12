# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthSystemObjectsRepairResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InRepairingQueueObjects** | **List&lt;string&gt;** | The objects were queued for repairing  | [optional] 
**FailedRepairObjects** | [**List&lt;VsanFailedRepairObjectResult&gt;**](VsanFailedRepairObjectResult.md) | All of objects which are failed to be repaired  | [optional] 
**IssueFound** | **bool** | True if ANY of host is failed to repair the objects belonging to them  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

