# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsLifecycleHookConfig
The Esx.Settings.Clusters.Vms.LifecycleHookConfig schema contains properties that describe a VM lifecycle hook configuration. See *Esx.Settings.Clusters.Vms.LifecycleHooks*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timeout** | **long** | The maximum time in seconds for vLCM to wait for a hook to be processed by the solution. An issue is raised if the time elapsed and the hook is still not processed. See *Esx.Settings.Clusters.Vms.Solutions.IssueInfo*. The issue is attached to the *Esx.Settings.Clusters.Vms.Solutions.DeploymentInfo* structure that holds the VM for which the hook was activated.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60;, defaults to 10 hours. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

