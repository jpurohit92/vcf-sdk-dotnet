# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupJobDetailsFilterSpec
The Appliance.Recovery.Backup.Job.Details.FilterSpec schema contains properties used to filter the results when listing backup jobs details (see *GET /appliance/recovery/backup/job/details*).  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Jobs** | **List&lt;string&gt;** | Identifiers of backup jobs that can match the filter.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the filter will match all the backup jobs.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.appliance.recovery.backup.job&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.appliance.recovery.backup.job&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

