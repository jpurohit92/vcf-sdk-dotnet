# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSystemNameArchiveSummary
The Appliance.Recovery.Backup.SystemName.Archive.Summary schema contains commonly used information about a backup archive.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archive** | **string** | Backup archive identifier.  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.backup.system_name.archive&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.backup.system_name.archive&#x60;. | 
**Timestamp** | **DateTime** | Time when this backup was started.  This property was added in __vSphere API 6.7__. | 
**VarVersion** | **string** | The version of the appliance represented by the backup archive.  This property was added in __vSphere API 6.7__. | 
**Comment** | **string** | Custom comment added by the user for this backup.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

