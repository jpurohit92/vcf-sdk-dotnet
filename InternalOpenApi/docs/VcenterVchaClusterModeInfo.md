# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterModeInfo
The Vcenter.Vcha.Cluster.Mode.Info schema contains the mode of the VCHA Cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Identifies the mode of the VCHA cluster.  Possible values:   - &#x60;ENABLED&#x60;: VCHA Cluster is enabled. State replication between the Active and Passive node is enabled and automatic failover is allowed.   - &#x60;DISABLED&#x60;: VCHA Cluster is disabled. State replication between the Active and Passive node is disabled and automatic failover is not allowed.   - &#x60;MAINTENANCE&#x60;: VCHA Cluster is in maintenance mode. State replication between the and Passive node is enabled but automatic failover is not allowed.   For more information see: *Vcenter.Vcha.Cluster.Mode.ClusterMode*.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

