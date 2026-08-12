# Vcenter.Automation.OpenApi.Model.ContentConfigurationSetting
The Content.ConfigurationSetting schema defines the settings of a global configuration on the Content Library Service.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the configuration.  This property was added in __vSphere API 9.1.0.0__. | 
**RebootRequired** | **bool** | Flag indicates if reboot of the Content Library Service is required to apply the change after the configuration&#39;s value is updated.  This property was added in __vSphere API 9.1.0.0__. | 
**Constraints** | **List&lt;Dictionary&lt;string, string&gt;&gt;** | The constraints that can apply to the value of the configuration. Each entry has ConstraintType and value.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

