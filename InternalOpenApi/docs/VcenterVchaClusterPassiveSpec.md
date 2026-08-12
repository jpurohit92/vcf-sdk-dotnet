# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterPassiveSpec
The Vcenter.Vcha.Cluster.PassiveSpec schema contains the deploy specification for the Passive Node of the VCHA cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Placement** | [**VcenterVchaPlacementSpec**](VcenterVchaPlacementSpec.md) | Contains the placement configuration of the node.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the it is assumed that the clone will be done manually by the customer. In this case, the placement configuration for the witness node should also be omitted. Only the network configuration will be setup. Once the passive and witness nodes are cloned from the active node, the VCHA high availability is turned on. | [optional] 
**HaIp** | [**VcenterVchaIpSpec**](VcenterVchaIpSpec.md) | IP specification for the HA network.  This property was added in __vSphere API 6.7.1__. | 
**FailoverIp** | [**VcenterVchaIpSpec**](VcenterVchaIpSpec.md) | IP specification for the management network.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then it will assume the public IP address of the Active vCenter Server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

