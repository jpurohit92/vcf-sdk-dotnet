# Vcenter.Automation.OpenApi.Model.EsxSettingsClusterParallelRemediationAction
The Esx.Settings.ClusterParallelRemediationAction schema contains properties that provide the settings to remediate multiple hosts of a cluster in parallel.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Enable parallel remediation for hosts in maintenance mode within a cluster.  This property was added in __vSphere API 9.1.0.0__. | 
**MaxHosts** | **long** | Maximum number of hosts that can be remediated in parallel. Setting *Esx.Settings.ClusterParallelRemediationAction.max_hosts* does not guarantee maxHosts to be remediated in parallel.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, number of hosts that can be remediated in parallel would be set to maximum number of hosts supported per cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

