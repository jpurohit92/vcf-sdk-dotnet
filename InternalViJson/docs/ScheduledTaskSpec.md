# Vcenter.ViJson.OpenApi.Model.ScheduledTaskSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the scheduled task.  | 
**Description** | **string** | Description of the scheduled task.  | 
**Enabled** | **bool** | Flag to indicate whether the scheduled task is enabled or disabled.  | 
**Scheduler** | [**TaskScheduler**](TaskScheduler.md) | The time scheduler that determines when the scheduled task runs.  | 
**Action** | [**Action**](Action.md) | The action of the scheduled task, to be done when the scheduled task runs.  | 
**Notification** | **string** | The email notification.  If not set, this property is set to empty string, indicating no notification.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

