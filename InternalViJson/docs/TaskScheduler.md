# Vcenter.ViJson.OpenApi.Model.TaskScheduler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveTime** | **DateTime** | The time that the schedule for the task takes effect.  Task activation is distinct from task execution. When you activate a task, its schedule starts, and when the next execution time occurs, the task will run. If you do not set activeTime, the activation time defaults to the time that you create the scheduled task.  | [optional] 
**ExpireTime** | **DateTime** | The time the schedule for the task expires.  If you do not set expireTime, the schedule does not expire.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

