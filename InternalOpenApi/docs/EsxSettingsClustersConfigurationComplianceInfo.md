# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationComplianceInfo
The Esx.Settings.Clusters.Configuration.ComplianceInfo schema contains properties that describe the configuration drift between the desired document and the configurations on the ESXi host or cluster solution.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sets** | [**List&lt;EsxSettingsClustersConfigurationSettingCompliance&gt;**](EsxSettingsClustersConfigurationSettingCompliance.md) | List of configuration drifts represented by *Esx.Settings.Clusters.Configuration.SettingCompliance*. Each describing a configuration whose value on ESXi host or cluster solution is different to that in the desired document  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; if there are no drifts to report in this category. | [optional] 
**Adds** | [**List&lt;EsxSettingsClustersConfigurationSettingCompliance&gt;**](EsxSettingsClustersConfigurationSettingCompliance.md) | List of configuration drifts represented by *Esx.Settings.Clusters.Configuration.SettingCompliance*. Each describing a configuration that is present in the desired document but absent on the ESXi host or cluster solution.  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; if there are no drifts to report in this category. | [optional] 
**Deletes** | [**List&lt;EsxSettingsClustersConfigurationSettingCompliance&gt;**](EsxSettingsClustersConfigurationSettingCompliance.md) | List of configuration drifts represented by *Esx.Settings.Clusters.Configuration.SettingCompliance*. Each describing a configuration that is present on the ESXi host or cluster solution but absent in the desired document.  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; if there are no drifts to report in this category. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

