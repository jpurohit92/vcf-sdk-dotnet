# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterWitnessInfo
The Vcenter.Vcha.Cluster.WitnessInfo schema defines the configuration and runtime information for the witness node in the cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HaIp** | [**VcenterVchaClusterIpInfo**](VcenterVchaClusterIpInfo.md) | VCHA Cluster network configuration of the node. All cluster communication (state replication, heartbeat, cluster messages) happens over this network.    The active node&#39;s management vCenter server credentials are not required to populate *Vcenter.Vcha.Cluster.WitnessInfo.ha_ip*.  This property was added in __vSphere API 6.7.1__. | 
**Runtime** | [**VcenterVchaClusterNodeRuntimeInfo**](VcenterVchaClusterNodeRuntimeInfo.md) | Runtime information for the node in the VCHA Cluster.    The active node&#39;s management vCenter server credentials are required to populate some properties of *Vcenter.Vcha.Cluster.WitnessInfo.runtime*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the information is unavailable or the node is not cloned yet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

