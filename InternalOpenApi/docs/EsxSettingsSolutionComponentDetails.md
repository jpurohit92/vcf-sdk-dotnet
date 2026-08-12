# Vcenter.Automation.OpenApi.Model.EsxSettingsSolutionComponentDetails
The Esx.Settings.SolutionComponentDetails schema contains information that provide more details about component registered by the solution from depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Component** | **string** | Identifier of the component.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | 
**DisplayName** | **string** | Display name of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the component.  This property was added in __vSphere API 7.0.0.0__.  missing or &#x60;null&#x60; if no version is provided for the component. | [optional] 
**Vendor** | **string** | Vendor of the component.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

