# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterNodeRole
The Vcenter.Vcha.Cluster.NodeRole enumerated type defines the role node can be in a VCHA Cluster.  Possible values:   - `ACTIVE`: Node is having a role of Active. In this role, node runs a vCenter Server that serves client requests.   - `PASSIVE`: Node is having a role of Passive. In this role node, runs as a standby for the Active vCenter Server and receives state updates. This node takes over the role of Active vCenter Server upon failover.   - `WITNESS`: Node is having a role of Witness. In this role, node acts as a quorum node for avoiding the classic split-brain problem.   This enumeration was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

