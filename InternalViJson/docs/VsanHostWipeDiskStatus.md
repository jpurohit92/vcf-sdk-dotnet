# Vcenter.ViJson.OpenApi.Model.VsanHostWipeDiskStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | **string** | Disk canonical name to query.  | 
**Eligible** | **string** | Disk eligible for wipe or not.  See also *VsanHostWipeDiskEligible_enum*.  | 
**IneligibleReason** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Disk wipe ineligible reason.  This property is used when disk is ineligible for wipe. Includes following reasons: The disk is either in use by vSAN OSA disk group, or the disk is in use by vSAN ESA storage pool, or the disk is ineligible for use by vSAN, or the disk does not support sanitize, or the disk has wipe ongoing.  | [optional] 
**WipeState** | **string** | Disk wipe state.  This property is used when disk is being wiped or has been wiped. It will be unset when a wiped disk is claimed again in vSAN.  See also *VsanHostWipeDiskState_enum*.  | [optional] 
**PercentageCompleted** | **int** | Wipe percentage completed.  This property is used when disk wipe state is \&quot;Wiping\&quot;.  | [optional] 
**EstimatedTime** | **long** | Estimated time to finish in seconds.  This property is used when disk wipe state is \&quot;Wiping\&quot;.  | [optional] 
**WipeStartTime** | **DateTime** | Wipe disk start timestamp (UTC time).  This property is used when disk wipe state is set.  | [optional] 
**WipeCompleteTime** | **DateTime** | Wipe disk complete timestamp (UTC time).  This property is used when disk wipe state is \&quot;Success\&quot;, or \&quot;Failure\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

