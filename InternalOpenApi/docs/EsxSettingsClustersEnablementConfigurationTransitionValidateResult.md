# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionValidateResult
The Esx.Settings.Clusters.Enablement.Configuration.Transition.ValidateResult schema contains properties that describe the validity of the imported desired configuration, and compliance information.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status indicating whether the configuration draft validated successfully.  Possible values:   - &#x60;INVALID&#x60;: This indicates that the configuration draft is invalid.   - &#x60;VALID&#x60;: This indicates that the configuration draft is valid.   For more information see: *Esx.Settings.Clusters.Enablement.Configuration.Transition.ValidateResult.Status*.  This property was added in __vSphere API 8.0.1.0__. | 
**Errors** | [**List&lt;EsxSettingsClustersConfigurationValidationError&gt;**](EsxSettingsClustersConfigurationValidationError.md) | Lists all validation errors identified in the configuration draft.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Enablement.Configuration.Transition.ValidateResult.Status.INVALID*. | [optional] 
**Compliance** | [**EsxSettingsClustersConfigurationClusterCompliance**](EsxSettingsClustersConfigurationClusterCompliance.md) | Cluster Compliance result.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Enablement.Configuration.Transition.ValidateResult.Status.VALID*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

