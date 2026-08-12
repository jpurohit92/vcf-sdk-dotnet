# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationValidationResult
This Esx.Settings.Clusters.Configuration.ValidationResult schema contains properties that describe the result of validating a configuration document.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valid** | **bool** | This boolean flag indicates whether the configuration document validated successfully with no validation errors.  This property was added in __vSphere API 8.0.1.0__. | 
**Errors** | [**List&lt;EsxSettingsClustersConfigurationValidationError&gt;**](EsxSettingsClustersConfigurationValidationError.md) | Lists all validation errors identified in the configuration document.  This property was added in __vSphere API 8.0.1.0__.  This is set when *Esx.Settings.Clusters.Configuration.ValidationResult.valid* is false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

