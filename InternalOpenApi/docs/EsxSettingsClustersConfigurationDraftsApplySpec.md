# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsApplySpec
The Esx.Settings.Clusters.Configuration.Drafts.ApplySpec schema contains properties that are used to create a new commit.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Message to include with the commit.  This property was added in __vSphere API 8.0.2.0__.  If missing or &#x60;null&#x60;, message is set to empty string. | [optional] 
**ApplyPolicySpec** | [**EsxSettingsClustersPoliciesApplyEffectiveEffectivePolicySpec**](EsxSettingsClustersPoliciesApplyEffectiveEffectivePolicySpec.md) | The parameter can be used to override the default remediation policies for the apply task.  This property was added in __vSphere API 8.0.2.0__.  if missing or &#x60;null&#x60; the default cluster remediation policies are used. | [optional] 
**DriftReviews** | [**List&lt;EsxSettingsClustersConfigurationDriftReview&gt;**](EsxSettingsClustersConfigurationDriftReview.md) | This field contains the drifts that need review from the user before apply.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

