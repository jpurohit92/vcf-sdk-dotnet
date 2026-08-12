# Vcenter.Automation.OpenApi.Model.EsxSettingsClusterSoftwarePolicySpecResetInfo
This Esx.Settings.ClusterSoftwarePolicySpecResetInfo schema contains properties that describes the outcome when the settings that govern the *POST /esx/settings/clusters/{cluster}/software?action=apply* API behaviour are reset.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**EsxSettingsClusterSoftwarePolicySpec**](EsxSettingsClusterSoftwarePolicySpec.md) | The configured values of *Esx.Settings.Clusters.Policies.Apply.ConfiguredPolicySpec.software_policy_spec*.  This property was added in __vSphere API 9.1.0.0__. | 
**To** | [**EsxSettingsClusterSoftwarePolicySpec**](EsxSettingsClusterSoftwarePolicySpec.md) | The values of *Esx.Settings.Clusters.Policies.Apply.ConfiguredPolicySpec.software_policy_spec* when the configured value is reset.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

