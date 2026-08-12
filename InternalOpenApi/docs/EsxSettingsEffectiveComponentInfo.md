# Vcenter.Automation.OpenApi.Model.EsxSettingsEffectiveComponentInfo
The Esx.Settings.EffectiveComponentInfo schema contains information that describe a component and how that component appeared in the software specification.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | Version of the component. It will be empty if the component is removed.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**EsxSettingsEffectiveComponentDetails**](EsxSettingsEffectiveComponentDetails.md) | Details about the effective component.  This property was added in __vSphere API 7.0.0.0__.  missing or &#x60;null&#x60; if component is not present in the depot. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

