# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupPartsPart
Appliance.Recovery.Backup.Parts.Part schema Structure representing backup restore part

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | part ID  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.backup.parts&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.backup.parts&#x60;. | 
**Name** | [**ApplianceRecoveryBackupPartsLocalizableMessage**](ApplianceRecoveryBackupPartsLocalizableMessage.md) | part name id in message bundle | 
**Description** | [**ApplianceRecoveryBackupPartsLocalizableMessage**](ApplianceRecoveryBackupPartsLocalizableMessage.md) | part description id in message bundle | 
**SelectedByDefault** | **bool** | Is this part selected by default in the user interface. | 
**Optional** | **bool** | Is this part optional. | 
**Standalone** | **bool** | This flag will be &#x60;true&#x60; if this part can be restored independently of an entire VCSA restore  This property was added in __vSphere API 8.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

