# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSchedulesRecurrenceInfo
The Appliance.Recovery.Backup.Schedules.RecurrenceInfo schema contains the recurrence information associated with a schedule.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Minute** | **long** | Minute when backup should run.  This property was added in __vSphere API 6.7__. | 
**Hour** | **long** | Hour when backup should run. The hour should be specified in 24-hour clock format.  This property was added in __vSphere API 6.7__. | 
**Days** | **List&lt;string&gt;** | Day of week when the backup should be run. Days can be specified as list of days.  Possible values:   - &#x60;MONDAY&#x60;: Monday   - &#x60;TUESDAY&#x60;: Tuesday   - &#x60;WEDNESDAY&#x60;: Wednesday   - &#x60;THURSDAY&#x60;: Thursday   - &#x60;FRIDAY&#x60;: Friday   - &#x60;SATURDAY&#x60;: Saturday   - &#x60;SUNDAY&#x60;: Sunday   For more information see: *Appliance.Recovery.Backup.Schedules.DayOfWeek*.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the backup will be run everyday. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

