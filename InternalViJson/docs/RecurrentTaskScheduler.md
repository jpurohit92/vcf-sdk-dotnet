# Vcenter.ViJson.OpenApi.Model.RecurrentTaskScheduler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveTime** | **DateTime** | The time that the schedule for the task takes effect.  Task activation is distinct from task execution. When you activate a task, its schedule starts, and when the next execution time occurs, the task will run. If you do not set activeTime, the activation time defaults to the time that you create the scheduled task.  | [optional] 
**ExpireTime** | **DateTime** | The time the schedule for the task expires.  If you do not set expireTime, the schedule does not expire.  | [optional] 
**Interval** | **int** | How often to run the scheduled task.  The value must be greater than or equal to 1 and less than 1000. The default value is 1. The interval acts as a multiplier for the unit of time associated with a particular scheduler (hours, days, weeks, or months). For example, setting the *HourlyTaskScheduler* interval to 4 causes the task to run every 4 hours.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

