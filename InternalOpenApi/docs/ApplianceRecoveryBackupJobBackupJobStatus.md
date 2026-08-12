# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupJobBackupJobStatus
The Appliance.Recovery.Backup.Job.BackupJobStatus schema represents the status of a backup/restore job.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | TimeStamp based ID. | 
**State** | **string** | The state of the backup job.  Possible values:   - &#x60;FAILED&#x60;: Backup/Restore job failed.   - &#x60;INPROGRESS&#x60;: Backup/Restore job is in progress.   - &#x60;NONE&#x60;: Backup/Restore job is not started.   - &#x60;SUCCEEDED&#x60;: Backup/Restore job completed successfully.   For more information see: *Appliance.Recovery.Backup.Job.BackupRestoreProcessState*. | 
**Messages** | [**List&lt;ApplianceRecoveryBackupJobLocalizableMessage&gt;**](ApplianceRecoveryBackupJobLocalizableMessage.md) | List of messages. | 
**Progress** | **long** | Progress of the job in percentage. | 
**StartTime** | **DateTime** | Time when the backup was started. | 
**EndTime** | **DateTime** | Time when the backup was finished.  If missing or &#x60;null&#x60; end time is None until backup is finished. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

