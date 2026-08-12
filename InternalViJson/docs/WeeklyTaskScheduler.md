# Vcenter.ViJson.OpenApi.Model.WeeklyTaskScheduler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hour** | **int** | The hour at which the *RecurrentTaskScheduler* runs the task.  Use UTC (Coordinated Universal Time) values in the range 0 to 23, where 0 &#x3D; 12:00 a.m. (UTC) and 12 &#x3D; 12:00 p.m. (UTC).  For vCenter 2.x and prior releases, use the server&#39;s local time. For example, use Eastern Standard Time (EST) or Pacific Daylight Time (PDT), rather than UTC.  | 
**Sunday** | **bool** | The day or days of the week when the scheduled task will run.  At least one of the days must be true.  | 
**Monday** | **bool** |  | 
**Tuesday** | **bool** |  | 
**Wednesday** | **bool** |  | 
**Thursday** | **bool** |  | 
**Friday** | **bool** |  | 
**Saturday** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

