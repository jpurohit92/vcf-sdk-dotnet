# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotContentComponentsSummary
The Esx.Settings.DepotContent.Components.Summary schema defines the summary information regarding a component.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Component.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | 
**DisplayName** | **string** | Display name of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**Vendor** | **string** | Vendor of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**Versions** | [**List&lt;EsxSettingsDepotContentComponentsComponentVersionSummary&gt;**](EsxSettingsDepotContentComponentsComponentVersionSummary.md) | Summary information about the versions of this component. These are sorted by the version.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

