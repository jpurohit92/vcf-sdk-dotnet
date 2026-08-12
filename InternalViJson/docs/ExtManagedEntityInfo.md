# Vcenter.ViJson.OpenApi.Model.ExtManagedEntityInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Managed entity type, as defined by the extension.  This matches the *type* field in the configuration about a virtual machine or vApp.  | 
**SmallIconUrl** | **string** | The URL to a 16x16 pixel icon in PNG format for entities of this type managed by this extension.  The design of the icon should allow for the possibility of it being badged with the power state of the entity by the vSphere client. If you do not provide this icon, the icon at *iconUrl*, if found, is scaled down to 16x16 pixels.  | [optional] 
**IconUrl** | **string** | The URL to an icon in PNG format that is no larger than 256x256 pixels.  This icon will be scaled to 16x16, 32x32, 64x64, and 128x128 if needed. The icon is shown for all entities of this type managed by this extension.  | [optional] 
**Description** | **string** | Description of this managed entity type.  This is typically displayed by clients, and should provide users with information about the function of entities of this type.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

