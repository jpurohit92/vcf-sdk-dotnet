# Vcenter.Automation.OpenApi.Model.EsxSettingsSolutionInfo
The Esx.Settings.SolutionInfo schema contains information that describe solution registered in the software specification.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Details** | [**EsxSettingsSolutionDetails**](EsxSettingsSolutionDetails.md) | Details about the solution from the depot.  This property was added in __vSphere API 7.0.0.0__.  missing or &#x60;null&#x60; if solution is not present in the depot. | [optional] 
**VarVersion** | **string** | Version of the solution.  This property was added in __vSphere API 7.0.0.0__. | 
**Components** | [**List&lt;EsxSettingsSolutionComponentSpec&gt;**](EsxSettingsSolutionComponentSpec.md) | Components registered by the solution.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

