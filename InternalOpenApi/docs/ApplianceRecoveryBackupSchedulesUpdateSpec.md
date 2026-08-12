# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSchedulesUpdateSpec
The Appliance.Recovery.Backup.Schedules.UpdateSpec schema contains the fields of the existing schedule which can be updated.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;string&gt;** | List of optional parts. Use the *GET /appliance/recovery/backup/parts* operation to get information about the supported parts.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**BackupPassword** | **string** | Password for a backup piece. The backupPassword must adhere to the following password requirements: At least 8 characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII characters (for example, no space).  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**Location** | **string** | URL of the backup location.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**LocationUser** | **string** | Username for the given location.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**LocationPassword** | **string** | Password for the given location.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**Enable** | **bool** | Enable or disable a schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**RecurrenceInfo** | [**ApplianceRecoveryBackupSchedulesRecurrenceInfo**](ApplianceRecoveryBackupSchedulesRecurrenceInfo.md) | Recurrence information for the schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the infomration will not be changed. See *Appliance.Recovery.Backup.Schedules.RecurrenceInfo* | [optional] 
**RetentionInfo** | [**ApplianceRecoveryBackupSchedulesRetentionInfo**](ApplianceRecoveryBackupSchedulesRetentionInfo.md) | Retention information for the schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the information will not be changed. See *Appliance.Recovery.Backup.Schedules.RetentionInfo* | [optional] 
**FastBackup** | **bool** | Option to enable Postgres DB/ VCDB fast backup  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; backup will proceed at slow rate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

