# Vcenter.ViJson.OpenApi.Model.VsanRepairObjectsResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InQueueObjects** | **List&lt;string&gt;** | The objects which have been successfully enqueued for repairing.  | [optional] 
**FailedRepairObjects** | [**List&lt;VsanFailedRepairObjectResult&gt;**](VsanFailedRepairObjectResult.md) | The objects which is failed to be fixed with a certain failure message  | [optional] 
**NotInQueueObjects** | **List&lt;string&gt;** | The objects which weren&#39;t enqueued for repair due to the CLOM queue being full.  Caller needs retry repairing these objects.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

