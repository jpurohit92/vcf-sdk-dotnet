# Vcenter.ViJson.OpenApi.Model.PassiveNodeNetworkSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpSettings** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | VCHA Cluster network configuration of the node.  All cluster communication (state replication, heartbeat, cluster messages) happens over this network.  | 
**FailoverIpSettings** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | Failover IP address that this node must assume after the failover to serve client requests.  If not specified, it will assume the public IP address of the Active vCenter Server.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

