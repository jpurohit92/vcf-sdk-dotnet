# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotContentComponentsComponentVersionSummary
The Esx.Settings.DepotContent.Components.ComponentVersionSummary schema defines the summary information regarding a version of a component.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | Version of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**Summary** | **string** | Summary of the component version.  This property was added in __vSphere API 7.0.0.0__. | 
**Category** | **string** | Category of the component version.  Possible values:   - &#x60;SECURITY&#x60;: Security   - &#x60;ENHANCEMENT&#x60;: Enhancement   - &#x60;BUGFIX&#x60;: Bugfix   - &#x60;RECALL&#x60;: Recall   - &#x60;RECALL_FIX&#x60;: Recall-fix   - &#x60;INFO&#x60;: Info   - &#x60;MISC&#x60;: Misc   - &#x60;GENERAL&#x60;: General   For more information see: *Esx.Settings.DepotContent.Components.CategoryType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Urgency** | **string** | Urgency of the component version.  Possible values:   - &#x60;CRITICAL&#x60;: Critical   - &#x60;IMPORTANT&#x60;: Important   - &#x60;MODERATE&#x60;: Moderate   - &#x60;LOW&#x60;: Low   - &#x60;GENERAL&#x60;: General   For more information see: *Esx.Settings.DepotContent.Components.UrgencyType*.  This property was added in __vSphere API 7.0.0.0__. | 
**Kb** | **string** | Link to kb article related to this the component version.  This property was added in __vSphere API 7.0.0.0__. | 
**ReleaseDate** | **DateTime** | Release date of the component version.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

