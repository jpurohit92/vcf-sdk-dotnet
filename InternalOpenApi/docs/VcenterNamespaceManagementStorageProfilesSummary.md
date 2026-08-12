# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementStorageProfilesSummary
The Vcenter.NamespaceManagement.Storage.Profiles.Summary schema contains the information about compatible storage profiles and represents the result of *POST /vcenter/namespace-management/storage/profiles?action=check_compatibility* operation.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | **string** | Identifier of the compatible storage profile. A storage profile is compatible if it results in at least one datastore in each of the specified zones.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | 
**ProfileName** | **string** | Human-readable identifier of the storage profile.  This property was added in __vSphere API 8.0.0.1__. | 
**Compatible** | **bool** | Compatibility of this storage profile with the specified vSphere Zones.  This property was added in __vSphere API 8.0.0.1__. | 
**Items** | [**List&lt;VcenterNamespaceManagementStorageProfilesItem&gt;**](VcenterNamespaceManagementStorageProfilesItem.md) | The list of Vcenter.NamespaceManagement.Storage.Profiles.Item which correspond to the storage profile.  This property was added in __vSphere API 8.0.0.1__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | The reason for incompatibility. If empty, this profile is compatible with the given vSphere Zones specified in the *Vcenter.NamespaceManagement.Storage.Profiles.FilterSpec*.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

