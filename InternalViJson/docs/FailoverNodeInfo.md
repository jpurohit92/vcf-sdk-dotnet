# Vcenter.ViJson.OpenApi.Model.FailoverNodeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterIpSettings** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | VCHA Cluster network configuration of the node.  All cluster communication (state replication, heartbeat, cluster messages) happens over this network.  | 
**FailoverIp** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | Failover IP address that this node will assume after the failover to serve client requests.  Each failover node can have a different failover IP address.  | [optional] 
**BiosUuid** | **string** | BIOS UUID for the node.  It is set only if the VCHA Cluster was formed using automatic provisioning by the deploy API.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

