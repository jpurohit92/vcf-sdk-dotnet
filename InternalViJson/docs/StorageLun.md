# Vcenter.ViJson.OpenApi.Model.StorageLun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Unique Indentfier  | 
**VSphereLunIdentifier** | **string** | Identifier reported by vSphere(ESX) for this LUN  | 
**VendorDisplayName** | **string** | Display Name which appears in storage array management console  | 
**CapacityInMB** | **long** | Capacity In MB  | 
**UsedSpaceInMB** | **long** | Used space in MB for a thin provisioned LUN  | 
**LunThinProvisioned** | **bool** | Indicates whether the LUN is thin provisioned  | 
**AlternateIdentifier** | **List&lt;string&gt;** | Alternate identifiers associated with the LUN  | [optional] 
**DrsManagementPermitted** | **bool** | Indicates whether Storage DRS is permitted to manage performance between this LUN and other LUNs from the same array.  | 
**ThinProvisioningStatus** | **string** |  | 
**BackingConfig** | [**BackingConfig**](BackingConfig.md) | Backing config information  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

