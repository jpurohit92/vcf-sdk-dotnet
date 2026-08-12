# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationApplySpec
The Esx.Settings.Clusters.Configuration.ApplySpec schema contains properties that describe the specification to be used for applying the desired configuration to a cluster.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | **string** | The minimum commit identifier of the desired configuration to be used during the *POST /esx/settings/clusters/{cluster}/configuration?action&#x3D;apply* operation.  This property was added in __vSphere API 8.0.1.0__.  if missing or &#x60;null&#x60; or empty the apply operation will use the latest commit to fetch the desired configuration.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | [optional] 
**Hosts** | **List&lt;string&gt;** | The specific hosts within the cluster to be considered during the *POST /esx/settings/clusters/{cluster}/configuration?action&#x3D;apply* operation.  This property was added in __vSphere API 8.0.1.0__.  if missing or &#x60;null&#x60; or empty the *POST /esx/settings/clusters/{cluster}/configuration?action&#x3D;apply* operation will remediate all hosts within the cluster.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**ApplyPolicySpec** | [**EsxSettingsClustersPoliciesApplyEffectiveEffectivePolicySpec**](EsxSettingsClustersPoliciesApplyEffectiveEffectivePolicySpec.md) | The parameter can be used to override the default remediation policies for the task.  This property was added in __vSphere API 8.0.1.0__.  if missing or &#x60;null&#x60; the default cluster remediation policies are used. | [optional] 
**DriftReviews** | [**List&lt;EsxSettingsClustersConfigurationDriftReview&gt;**](EsxSettingsClustersConfigurationDriftReview.md) | This field contains the drifts that need review from the user before apply.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

