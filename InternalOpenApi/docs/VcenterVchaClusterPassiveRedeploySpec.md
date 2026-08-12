# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterPassiveRedeploySpec
The Vcenter.Vcha.Cluster.Passive.RedeploySpec schema contains the redeploy specification.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcSpec** | [**VcenterVchaCredentialsSpec**](VcenterVchaCredentialsSpec.md) | Contains the active node&#39;s management vCenter server credentials.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode and managed by a linked vCenter Server instance. | [optional] 
**Placement** | [**VcenterVchaPlacementSpec**](VcenterVchaPlacementSpec.md) | Contains the node&#39;s placement information.  This property was added in __vSphere API 6.7.1__. | 
**HaIp** | [**VcenterVchaIpSpec**](VcenterVchaIpSpec.md) | Contains the VCHA HA network configuration of the node. All cluster communication (state replication, heartbeat, cluster messages) happens over this network.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the stored network configuration for the VCHA HA network for the passive node will be used. | [optional] 
**FailoverIp** | [**VcenterVchaIpSpec**](VcenterVchaIpSpec.md) | Failover IP address that this node must assume after the failover to serve client requests.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the public IP address of the Active vCenter Server is assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

