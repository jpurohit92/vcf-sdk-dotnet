# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupJobReturnResult
The Appliance.Recovery.Backup.Job.ReturnResult schema contains the result information for the cancel operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of the cancel operation.  Possible values:   - &#x60;FAIL&#x60;: Cancel operation failed.   - &#x60;WARNING&#x60;: Cancel operation passed with warnings.   - &#x60;OK&#x60;: Cancel operation succeeded.   For more information see: *Appliance.Recovery.Backup.Job.ReturnStatus*. | 
**Messages** | [**List&lt;ApplianceRecoveryBackupJobLocalizableMessage&gt;**](ApplianceRecoveryBackupJobLocalizableMessage.md) | List of messages. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

