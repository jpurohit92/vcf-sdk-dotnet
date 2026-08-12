# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationValidationError
The Esx.Settings.Clusters.Configuration.ValidationError schema contains properties that describes a validation error in the configuration.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Full path to the configuration or the property within the configuration which was found to be invalid.  This property was added in __vSphere API 8.0.1.0__. | 
**DisplayPath** | **List&lt;string&gt;** | A list of the display names for components of *Esx.Settings.Clusters.Configuration.ValidationError.path* property.  This property was added in __vSphere API 9.1.0.0__.  This field is missing or &#x60;null&#x60; if the display names cannot be computed. | [optional] 
**Messages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Localized error message describing the validation error.  This property was added in __vSphere API 8.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

