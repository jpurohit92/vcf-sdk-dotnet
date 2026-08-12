# Vcenter.Automation.OpenApi.Model.EsxSettingsDefaultsClustersPoliciesApplyParallelRemediationAction
The Esx.Settings.Defaults.Clusters.Policies.Apply.ParallelRemediationAction schema contains properties that provide settings to remediate multiple hosts of a cluster in parallel.  This schema will be deprecated in the future. It is recommended to use *Esx.Settings.ClusterParallelRemediationAction* instead.   This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Enable parallel remediation for hosts in maintenance mode within a cluster.  This property was added in __vSphere API 8.0.0.1__. | 
**MaxHosts** | **long** | Maximum number of hosts that can be remediated in parallel Setting *Esx.Settings.Defaults.Clusters.Policies.Apply.ParallelRemediationAction.max_hosts* does not guarantee maxHosts to be remediated in parallel.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, number of hosts that can be remediated in parallel would be set to maximum number of hosts supported per cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

