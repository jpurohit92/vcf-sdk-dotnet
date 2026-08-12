# Vcenter.Automation.OpenApi.Model.EsxSettingsDefaultsClustersPoliciesApplyFailureAction
The Esx.Settings.Defaults.Clusters.Policies.Apply.FailureAction schema contains properties that describe the actions to be taken when entering maintenance mode fails on a single host within the cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | What action (Action) is to be taken if entering maintenance mode fails on a single host within the cluster.  Possible values:   - &#x60;FAIL&#x60;: Fail the apply operation   - &#x60;RETRY&#x60;: Retry the task *Esx.Settings.Defaults.Clusters.Policies.Apply.FailureAction.retry_count* number of times on the failed host after *Esx.Settings.Defaults.Clusters.Policies.Apply.FailureAction.retry_delay*.   For more information see: *Esx.Settings.Defaults.Clusters.Policies.Apply.FailureAction.Action*.  This property was added in __vSphere API 7.0.0.0__. | 
**RetryDelay** | **long** | Time to wait to retry the failed operation in seconds.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of action is *Esx.Settings.Defaults.Clusters.Policies.Apply.FailureAction.Action.RETRY*. | [optional] 
**RetryCount** | **long** | Number of times to retry the failed operation.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of action is *Esx.Settings.Defaults.Clusters.Policies.Apply.FailureAction.Action.RETRY*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

