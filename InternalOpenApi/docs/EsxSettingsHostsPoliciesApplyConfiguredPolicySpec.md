# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsPoliciesApplyConfiguredPolicySpec
The Esx.Settings.Hosts.Policies.Apply.ConfiguredPolicySpec schema contains properties that describe the policies configured to be used when the software and configuration specification documents are applied to an ESXi host.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailureAction** | [**EsxSettingsHostsPoliciesApplyFailureAction**](EsxSettingsHostsPoliciesApplyFailureAction.md) | What action is to be taken if entering maintenance mode fails on an ESXi host.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, configured value would be unset. | [optional] 
**PreRemediationPowerAction** | **string** | Specifies what should be done to the power state of the VM before entering maintenance mode.  Possible values:   - &#x60;POWER_OFF_VMS&#x60;: Power off VMs before entering maintenance mode.   - &#x60;SUSPEND_VMS&#x60;: Suspend VMs before entering maintenance mode   - &#x60;DO_NOT_CHANGE_VMS_POWER_STATE&#x60;: Do not change the VM power state   - &#x60;SUSPEND_VMS_TO_MEMORY&#x60;: Suspend VMs to Memory before entering maintenance mode   For more information see: *Esx.Settings.Hosts.Policies.Apply.ConfiguredPolicySpec.PreRemediationPowerAction*.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, configured value would be unset. | [optional] 
**EnableQuickBoot** | **bool** | Enable Quick Boot during remediation of the host.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, configured value would be unset. | [optional] 
**SoftwarePolicySpec** | [**EsxSettingsHostSoftwarePolicySpec**](EsxSettingsHostSoftwarePolicySpec.md) | Software-specific policy settings applicable to the *POST /esx/settings/hosts/{host}/software?action&#x3D;apply* API.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, software-specific policy values will be unset. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

