# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterNodeRuntimeInfo
The Vcenter.Vcha.Cluster.NodeRuntimeInfo schema describes a node's runtime information in a VCHA Cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | Last known state of the node.    The active node&#39;s management vCenter server credentials are not required to populate *Vcenter.Vcha.Cluster.NodeRuntimeInfo.state*.  Possible values:   - &#x60;UP&#x60;: Node is up and has joined the VCHA Cluster.   - &#x60;DOWN&#x60;: Node is down and has left the VCHA Cluster.   For more information see: *Vcenter.Vcha.Cluster.NodeState*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then information is unavailable or the passive and witness nodes are not cloned yet. | [optional] 
**Role** | **string** | Last known role of the node.    The active node&#39;s management vCenter server credentials are not required to populate *Vcenter.Vcha.Cluster.NodeRuntimeInfo.role*.  Possible values:   - &#x60;ACTIVE&#x60;: Node is having a role of Active. In this role, node runs a vCenter Server that serves client requests.   - &#x60;PASSIVE&#x60;: Node is having a role of Passive. In this role node, runs as a standby for the Active vCenter Server and receives state updates. This node takes over the role of Active vCenter Server upon failover.   - &#x60;WITNESS&#x60;: Node is having a role of Witness. In this role, node acts as a quorum node for avoiding the classic split-brain problem.   For more information see: *Vcenter.Vcha.Cluster.NodeRole*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then information is unavailable or the passive and witness nodes are not cloned yet. | [optional] 
**Placement** | [**VcenterVchaPlacementInfo**](VcenterVchaPlacementInfo.md) | Placement information of the node.    The active node&#39;s management vCenter server credentials are required to populate most properties of *Vcenter.Vcha.Cluster.NodeRuntimeInfo.placement*.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the information is unavailable or the specified Active vCenter server management credentials are invalid or the node is not cloned yet or the VCHA cluster was deployed in a manual fashion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

