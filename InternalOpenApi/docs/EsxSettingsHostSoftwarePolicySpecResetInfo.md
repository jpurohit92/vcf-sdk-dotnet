# Vcenter.Automation.OpenApi.Model.EsxSettingsHostSoftwarePolicySpecResetInfo
This Esx.Settings.HostSoftwarePolicySpecResetInfo schema contains properties that describes the outcome when the configured settings that govern the software behaviour in the *POST /esx/settings/hosts/{host}/software?action=apply* API are reset.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**EsxSettingsHostSoftwarePolicySpec**](EsxSettingsHostSoftwarePolicySpec.md) | The configured values of *Esx.Settings.Hosts.Policies.Apply.ConfiguredPolicySpec.software_policy_spec*.  This property was added in __vSphere API 9.1.0.0__. | 
**To** | [**EsxSettingsHostSoftwarePolicySpec**](EsxSettingsHostSoftwarePolicySpec.md) | The values of *Esx.Settings.Hosts.Policies.Apply.ConfiguredPolicySpec.software_policy_spec* when the configured value is reset.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

