# Vcenter.Automation.OpenApi.Model.EsxSettingsComponentOverrideInfo
The Esx.Settings.ComponentOverrideInfo schema contains fields that describe how the component was overridden.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | Version of the component override.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the component override.  This property was added in __vSphere API 7.0.0.0__. | 
**Source** | **string** | Source of the component override.  Possible values:   - &#x60;BASE_IMAGE&#x60;: Base image is the source for this component   - &#x60;ADD_ON&#x60;: Addon is the source for this component   - &#x60;USER&#x60;: User is the source for this component   - &#x60;SOLUTION&#x60;: Solution is the source for this component   - &#x60;HARDWARE_SUPPORT_PACKAGE&#x60;: Hardware Support Package (HSP) is the source for this component  This constant was added in __vSphere API 7.0.0.0__.   - &#x60;USER_REMOVED&#x60;: This component was removed by the user  This constant was added in __vSphere API 8.0.3.0__.   For more information see: *Esx.Settings.ComponentSource*.  This property was added in __vSphere API 7.0.0.0__. | 
**Note** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Note explaining the override.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

