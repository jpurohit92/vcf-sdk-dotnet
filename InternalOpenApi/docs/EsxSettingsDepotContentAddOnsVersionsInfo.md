# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotContentAddOnsVersionsInfo
The Esx.Settings.DepotContent.AddOns.Versions.Info schema defines the information regarding a OEM add-on version.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Vendor** | **string** | Vendor of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Summary** | **string** | Summary of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | **string** | Description of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Category** | **string** | Category of the OEM add-on.  Possible values:   - &#x60;SECURITY&#x60;: Security   - &#x60;ENHANCEMENT&#x60;: Enhancement   - &#x60;BUGFIX&#x60;: Bugfix   For more information see: *Esx.Settings.DepotContent.AddOns.Versions.CategoryType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Kb** | **string** | Link to kb article related to this the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**ReleaseDate** | **DateTime** | Release date of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Components** | [**List&lt;EsxSettingsDepotContentAddOnsVersionsComponentInfo&gt;**](EsxSettingsDepotContentAddOnsVersionsComponentInfo.md) | List of components in this OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**RemovedComponents** | [**List&lt;EsxSettingsDepotContentAddOnsVersionsRemovedComponentInfo&gt;**](EsxSettingsDepotContentAddOnsVersionsRemovedComponentInfo.md) | List of components removed by this OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

