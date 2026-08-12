# Vcenter.Automation.OpenApi.Model.EsxSettingsSolutionDetails
The Esx.Settings.SolutionDetails schema contains information that provide more details about the solution from the depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the solution.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Display version of the solution.  This property was added in __vSphere API 7.0.0.0__. | 
**Components** | [**List&lt;EsxSettingsSolutionComponentDetails&gt;**](EsxSettingsSolutionComponentDetails.md) | Components registered by the solution. If the component is not present in the depot, then corresponding details are absent from the list.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

