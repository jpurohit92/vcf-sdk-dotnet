# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSchedulesInfo
The Appliance.Recovery.Backup.Schedules.Info schema contains information about an existing schedule. The structure includes Schedule ID, parts, location information, encryption password, enable flag, recurrence and retention information.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;string&gt;** | List of optional parts that will be included in backups based on this schedule details. Use the *GET /appliance/recovery/backup/parts* operation to get information about the supported parts.  This property was added in __vSphere API 6.7__. | 
**Location** | **string** | URL of the backup location.  This property was added in __vSphere API 6.7__. | 
**LocationUser** | **string** | Username for the given location.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; location user will not be used. | [optional] 
**Enable** | **bool** | Enable or disable a schedule, by default when created a schedule will be enabled.  This property was added in __vSphere API 6.7__. | 
**RecurrenceInfo** | [**ApplianceRecoveryBackupSchedulesRecurrenceInfo**](ApplianceRecoveryBackupSchedulesRecurrenceInfo.md) | Recurrence information for the schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; backup job is not scheduled. See *Appliance.Recovery.Backup.Schedules.RecurrenceInfo* | [optional] 
**RetentionInfo** | [**ApplianceRecoveryBackupSchedulesRetentionInfo**](ApplianceRecoveryBackupSchedulesRetentionInfo.md) | Retention information for the schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; all the completed backup jobs are retained forever. See *Appliance.Recovery.Backup.Schedules.RetentionInfo* | [optional] 
**FastBackup** | **bool** | Option to enable Postgres DB/ VCDB fast backup  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; backup will proceed at slow rate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

