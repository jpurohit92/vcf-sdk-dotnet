# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationHostResult
This Esx.Settings.Clusters.Configuration.HostResult schema contains properties that describe the result of the check compliance operation for an ESXi host and its cluster solutions.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostStatus** | [**EsxSettingsClustersConfigurationHostStatus**](EsxSettingsClustersConfigurationHostStatus.md) | This field represents the status of the check compliance operation. If status is OK, the result of operation can be retrieved from {#HostCompliance} {#Summary} field will summarize the status of the operation and if applicable, the specific error that occurred. Additionally, {#ValidationError} is populated if the operation fails due to host validation errors in desired document.  This property was added in __vSphere API 8.0.1.0__. | 
**Summary** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Summary of check compliance operation on the host.  This property was added in __vSphere API 8.0.1.0__. | 
**Errors** | [**List&lt;EsxSettingsClustersConfigurationValidationError&gt;**](EsxSettingsClustersConfigurationValidationError.md) | List of validation errors returned by either the host or the cluster solutions for that host. This is only set for a specific HostStatus ERROR case.  This property was added in __vSphere API 8.0.1.0__.  This field is set only if the document fails to validate on the host. | [optional] 
**HostCompliance** | [**EsxSettingsClustersConfigurationHostCompliance**](EsxSettingsClustersConfigurationHostCompliance.md) | This field provides compliance results for the host if the operation successfully completed on the host. That is, this field is populated only if HostStatus is OK.  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; if check compliance could not be completed on the host. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

