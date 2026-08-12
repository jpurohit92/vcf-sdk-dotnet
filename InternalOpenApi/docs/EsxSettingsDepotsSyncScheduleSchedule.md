# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsSyncScheduleSchedule
The Esx.Settings.Depots.SyncSchedule.Schedule schema defines a schedule.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Frequency of the schedule.  Possible values:   - &#x60;HOURLY&#x60;: Hourly.   - &#x60;DAILY&#x60;: Daily.   - &#x60;WEEKLY&#x60;: Weekly.   - &#x60;MONTHLY_BY_DAY&#x60;: Monthly by day.   For more information see: *Esx.Settings.Depots.SyncSchedule.Recurrence*.  This property was added in __vSphere API 7.0.0.0__. | 
**Skip** | **long** | This determines the units of Esx.Settings.Depots.SyncSchedule.Recurrence to skip before the scheduled task runs again. For example, value of 1 for HOURLY type means the scheduled task runs every 2 hours. The value must be within the range 0 to 998.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, no unit is skipped. | [optional] 
**Minute** | **long** | Minute at which schedule should be run. The value must be within the range 0 to 59.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is one of *Esx.Settings.Depots.SyncSchedule.Recurrence.HOURLY*, *Esx.Settings.Depots.SyncSchedule.Recurrence.DAILY*, *Esx.Settings.Depots.SyncSchedule.Recurrence.WEEKLY*, or *Esx.Settings.Depots.SyncSchedule.Recurrence.MONTHLY_BY_DAY*. | [optional] 
**Hour** | **long** | Hour at which schedule should be run. The value must be within the range 0 to 23.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is one of *Esx.Settings.Depots.SyncSchedule.Recurrence.DAILY*, *Esx.Settings.Depots.SyncSchedule.Recurrence.WEEKLY*, or *Esx.Settings.Depots.SyncSchedule.Recurrence.MONTHLY_BY_DAY*. | [optional] 
**DayOfMonth** | **long** | Day at which schedule should be run. The value must be within the range 1 to 31. If the value exceeds the total number of days in the month, the schedule will run on the last day of the month.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Esx.Settings.Depots.SyncSchedule.Recurrence.MONTHLY_BY_DAY*. | [optional] 
**DayOfWeek** | **string** | Day of the week when schedule should be run  Possible values:   - &#x60;SUNDAY&#x60;: Sunday.   - &#x60;MONDAY&#x60;: Monday.   - &#x60;TUESDAY&#x60;: Tuesday.   - &#x60;WEDNESDAY&#x60;: Wednesday.   - &#x60;THURSDAY&#x60;: Thursday.   - &#x60;FRIDAY&#x60;: Friday.   - &#x60;SATURDAY&#x60;: Saturday.   For more information see: *Esx.Settings.Depots.SyncSchedule.DayOfWeek*.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Esx.Settings.Depots.SyncSchedule.Recurrence.WEEKLY*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

