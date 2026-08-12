# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryRestoreMetadata
Appliance.Recovery.Restore.Metadata schema Structure representing metadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** | Time when this backup was completed. | 
**Parts** | **List&lt;string&gt;** | List of parts included in the backup. | 
**VarVersion** | **string** | VCSA version | 
**Boxname** | **string** | Box name is PNID/ FQDN etc | 
**SsoLoginRequired** | **bool** | Is SSO login required for the vCenter server.  This property was added in __vSphere API 6.7__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Comment** | **string** | Custom comment | 
**Applicable** | **bool** | Does the VCSA match the deployment type, network properties and version of backed up VC | 
**Messages** | [**List&lt;ApplianceRecoveryRestoreLocalizableMessage&gt;**](ApplianceRecoveryRestoreLocalizableMessage.md) | Any messages if the backup is not aplicable | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

