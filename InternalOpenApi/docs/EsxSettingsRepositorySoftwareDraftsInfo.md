# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareDraftsInfo
The Esx.Settings.Repository.Software.Drafts.Info schema defines the information about software draft.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | [**EsxSettingsRepositorySoftwareDraftsMetadata**](EsxSettingsRepositorySoftwareDraftsMetadata.md) | Metadata about the software draft.  This property was added in __vSphere API 9.0.0.0__. | 
**DisplayName** | **string** | Display name of the software draft.  This property was added in __vSphere API 9.0.0.0__. | 
**SoftwareSpec** | **string** | Identifier of the software in the repository for which this draft is created.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | 
**SoftwareInfo** | [**EsxSettingsSoftwareInfo**](EsxSettingsSoftwareInfo.md) | Software specification associated with the draft.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

