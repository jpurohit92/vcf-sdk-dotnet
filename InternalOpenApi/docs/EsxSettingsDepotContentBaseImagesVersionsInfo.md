# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotContentBaseImagesVersionsInfo
The Esx.Settings.DepotContent.BaseImages.Versions.Info schema defines the information regarding a base image.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**VarVersion** | **string** | Version of the base image.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.base_image&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.base_image&#x60;. | 
**DisplayVersion** | **string** | Human readable version of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**Summary** | **string** | Summary of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | **string** | Description of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**Category** | **string** | Category of the base image.  Possible values:   - &#x60;SECURITY&#x60;: Security   - &#x60;ENHANCEMENT&#x60;: Enhancement   - &#x60;BUGFIX&#x60;: Bugfix   For more information see: *Esx.Settings.DepotContent.BaseImages.Versions.CategoryType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Kb** | **string** | Link to kb article related to this the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**ReleaseDate** | **DateTime** | Release date of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**Components** | [**List&lt;EsxSettingsDepotContentBaseImagesVersionsComponentVersionInfo&gt;**](EsxSettingsDepotContentBaseImagesVersionsComponentVersionInfo.md) | List of components in this base image.  This property was added in __vSphere API 7.0.0.0__. | 
**QuickPatchCompatibleVersions** | **Dictionary&lt;string, string&gt;** | For base images this base image can quick patch from, map their full versions to display versions.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; this base image does not support quick patch.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.base_image&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.base_image&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

