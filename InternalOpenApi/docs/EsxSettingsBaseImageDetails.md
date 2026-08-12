# Vcenter.Automation.OpenApi.Model.EsxSettingsBaseImageDetails
The Esx.Settings.BaseImageDetails schema contains information that provide more details about the base image from the depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**ReleaseDate** | **DateTime** | Release date of the base image.  This property was added in __vSphere API 7.0.0.0__. | 
**QuickPatchCompatibleVersions** | **Dictionary&lt;string, string&gt;** | For base images this base image can quick patch from, map their full versions to display versions.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; this base image does not support quick patch.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.base_image&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.base_image&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

