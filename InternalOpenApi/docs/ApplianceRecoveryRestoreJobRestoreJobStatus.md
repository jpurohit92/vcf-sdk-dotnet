# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryRestoreJobRestoreJobStatus
Appliance.Recovery.Restore.Job.RestoreJobStatus schema Structure representing backup restore status

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | process state  Possible values:   - &#x60;FAILED&#x60;: Failed   - &#x60;INPROGRESS&#x60;: In progress   - &#x60;NONE&#x60;: Not started   - &#x60;SUCCEEDED&#x60;: Completed successfully   For more information see: *Appliance.Recovery.Restore.Job.BackupRestoreProcessState*. | 
**Messages** | [**List&lt;ApplianceRecoveryRestoreJobLocalizableMessage&gt;**](ApplianceRecoveryRestoreJobLocalizableMessage.md) | list of messages | 
**Progress** | **long** | percentage complete | 
**Parts** | **List&lt;string&gt;** | List of standalone parts requested for restore. Only parts with the *Appliance.Recovery.Backup.Parts.Part.standalone* flag set to &#x60;true&#x60; can be included.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; entire VCSA restore was requested. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

