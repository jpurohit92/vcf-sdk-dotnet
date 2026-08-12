# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSchedulesCreateSpec
The Appliance.Recovery.Backup.Schedules.CreateSpec schema contains fields to be specified for creating a new schedule. The structure includes parts, location information, encryption password and enable flag.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;string&gt;** | List of optional parts to be backed up. Use the *GET /appliance/recovery/backup/parts* operation to get information about the supported parts.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; all the optional parts will not be backed up. | [optional] 
**BackupPassword** | **string** | Password for a backup piece. The backupPassword must adhere to the following password requirements: At least 8 characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII characters (for example, no space).  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the backup piece will not be encrypted. | [optional] 
**Location** | **string** | URL of the backup location.  This property was added in __vSphere API 6.7__. | 
**LocationUser** | **string** | Username for the given location.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; authentication will not be used for the specified location. | [optional] 
**LocationPassword** | **string** | Password for the given location.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; authentication will not be used for the specified location. | [optional] 
**Enable** | **bool** | Enable or disable a schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the schedule will be enabled. | [optional] 
**RecurrenceInfo** | [**ApplianceRecoveryBackupSchedulesRecurrenceInfo**](ApplianceRecoveryBackupSchedulesRecurrenceInfo.md) | Recurrence information for the schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; backup job will not be scheduled. See *Appliance.Recovery.Backup.Schedules.RecurrenceInfo* | [optional] 
**RetentionInfo** | [**ApplianceRecoveryBackupSchedulesRetentionInfo**](ApplianceRecoveryBackupSchedulesRetentionInfo.md) | Retention information for the schedule.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; all the completed backup jobs will be retained forever. See *Appliance.Recovery.Backup.Schedules.RetentionInfo* | [optional] 
**FastBackup** | **bool** | Option to enable Postgres DB/ VCDB fast backup  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; backup will proceed at slow rate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

