# Vcenter.ViJson.OpenApi.Model.AfterStartupTaskScheduler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveTime** | **DateTime** | The time that the schedule for the task takes effect.  Task activation is distinct from task execution. When you activate a task, its schedule starts, and when the next execution time occurs, the task will run. If you do not set activeTime, the activation time defaults to the time that you create the scheduled task.  | [optional] 
**ExpireTime** | **DateTime** | The time the schedule for the task expires.  If you do not set expireTime, the schedule does not expire.  | [optional] 
**Minute** | **int** | The delay in minutes after vCenter server is restarted.  The value must be greater than or equal to 0.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

