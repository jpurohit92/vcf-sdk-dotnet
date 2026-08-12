# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSystemNameArchiveFilterSpec
The Appliance.Recovery.Backup.SystemName.Archive.FilterSpec schema contains properties used to filter the results when listing backup archives (see *POST /appliance/recovery/backup/system-name/{systemName}/archives?action=list*). If multiple properties are specified, only backup archives matching all of the properties match the filter.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTimestamp** | **DateTime** | Backup must have been taken on or after this time to match the filter.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the filter will match oldest backups. | [optional] 
**EndTimestamp** | **DateTime** | Backup must have been taken on or before this time to match the filter.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the filter will match most recent backups. | [optional] 
**CommentSubstring** | **string** | Backup comment must contain this string to match the filter.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the filter will match backups with any comment. | [optional] 
**MaxResults** | **long** | Limit result to a max count of most recent backups.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; it defaults to 128. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

