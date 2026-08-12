# Vcenter.Automation.OpenApi.Model.EsxSettingsDefaultsHostsPoliciesApplyEffectiveEffectivePolicySpec
The Esx.Settings.Defaults.Hosts.Policies.Apply.Effective.EffectivePolicySpec schema contains properties that describe the effective policies to be used when the software and configuration specification documents are applied to ESXi hosts.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailureAction** | [**EsxSettingsDefaultsHostsPoliciesApplyEffectiveFailureAction**](EsxSettingsDefaultsHostsPoliciesApplyEffectiveFailureAction.md) | What action is to be taken if entering maintenance mode fails on an ESXi host.  This property was added in __vSphere API 8.0.0.1__. | 
**PreRemediationPowerAction** | **string** | Specifies what should be done to the power state of the VM before entering maintenance mode.  Possible values:   - &#x60;POWER_OFF_VMS&#x60;: Power off VMs before entering maintenance mode.   - &#x60;SUSPEND_VMS&#x60;: Suspend VMs before entering maintenance mode   - &#x60;DO_NOT_CHANGE_VMS_POWER_STATE&#x60;: Do not change the VM power state   - &#x60;SUSPEND_VMS_TO_MEMORY&#x60;: Suspend VMs to Memory before entering maintenance mode   For more information see: *Esx.Settings.Defaults.Hosts.Policies.Apply.Effective.EffectivePolicySpec.PreRemediationPowerAction*.  This property was added in __vSphere API 8.0.0.1__. | 
**EnableQuickBoot** | **bool** | Enable Quick Boot during remediation of an ESXi host.  This property was added in __vSphere API 8.0.0.1__. | 
**SoftwarePolicySpec** | [**EsxSettingsHostSoftwarePolicySpec**](EsxSettingsHostSoftwarePolicySpec.md) | Software-specific policy settings applicable to the *POST /esx/settings/hosts/{host}/software?action&#x3D;apply* API.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

