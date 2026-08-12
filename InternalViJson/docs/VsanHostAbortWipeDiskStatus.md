# Vcenter.ViJson.OpenApi.Model.VsanHostAbortWipeDiskStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | **string** | Disk canonical name to abort.  | 
**Success** | **bool** | Disk wipe abort success or not.  | 
**Reason** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Disk wipe abort failure reason.  This property is used when failing to abort wipe on disk. Includes following reasons: Disk wipe is not in progress, or the disk doesn&#39;t support abort sanitize, or abort sanitize fails internally.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

