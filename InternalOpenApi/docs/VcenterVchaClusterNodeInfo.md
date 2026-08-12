# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterNodeInfo
The Vcenter.Vcha.Cluster.NodeInfo schema defines the configuration information for the active and passive nodes in the cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailoverIp** | [**VcenterVchaClusterIpInfo**](VcenterVchaClusterIpInfo.md) | Failover IP address that this node will assume after the failover to serve client requests. Each failover node can have a different failover IP address.    The active node&#39;s management vCenter server credentials are not required to populate *Vcenter.Vcha.Cluster.NodeInfo.failover_ip*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then it will assume the public IP address of the Active vCenter Server. | [optional] 
**HaIp** | [**VcenterVchaClusterIpInfo**](VcenterVchaClusterIpInfo.md) | VCHA Cluster network configuration of the node. All cluster communication (state replication, heartbeat, cluster messages) happens over this network.    The active node&#39;s management vCenter server credentials are not required to populate this *Vcenter.Vcha.Cluster.NodeInfo.ha_ip*.  This property was added in __vSphere API 6.7.1__. | 
**Runtime** | [**VcenterVchaClusterNodeRuntimeInfo**](VcenterVchaClusterNodeRuntimeInfo.md) | Runtime information for the node in the VCHA Cluster.    The active node&#39;s management vCenter server credentials are required to populate some properties of *Vcenter.Vcha.Cluster.NodeInfo.runtime*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the information is unavailable or the specified Active vCenter server management credentials are invalid or the node is not cloned yet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

