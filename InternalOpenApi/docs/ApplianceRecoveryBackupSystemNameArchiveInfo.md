# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupSystemNameArchiveInfo
The Appliance.Recovery.Backup.SystemName.Archive.Info schema represents backup archive information.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** | Time when this backup was completed.  This property was added in __vSphere API 6.7__. | 
**Location** | **string** | Backup location URL.  This property was added in __vSphere API 6.7__. | 
**Parts** | **List&lt;string&gt;** | List of parts included in the backup.  This property was added in __vSphere API 6.7__. | 
**VarVersion** | **string** | The version of the appliance represented by the backup.  This property was added in __vSphere API 6.7__. | 
**SystemName** | **string** | The system name identifier of the appliance represented by the backup.  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.backup.system_name&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.backup.system_name&#x60;. | 
**Comment** | **string** | Custom comment added by the user for this backup.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

