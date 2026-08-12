# Vcenter.ViJson.OpenApi.Model.HourlyTaskScheduler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **int** | How often to run the scheduled task.  The value must be greater than or equal to 1 and less than 1000. The default value is 1. The interval acts as a multiplier for the unit of time associated with a particular scheduler (hours, days, weeks, or months). For example, setting the *HourlyTaskScheduler* interval to 4 causes the task to run every 4 hours.  | 
**Minute** | **int** | The minute at which the *RecurrentTaskScheduler* runs the task.  Specify the minute value as a UTC (Coordinated Universal Time) value in the range 0 to 59.  For vCenter 2.x and prior releases, use the server&#39;s local time. For example, use Australia Northern Territory (UTC +9:30) or Indian (UTC +5:30) time values, rather than a UTC value.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

