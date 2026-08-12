# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterActiveInfo
The Vcenter.Vcha.Cluster.Active.Info schema contains the network and placement information of the active node of a VCHA Cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Management** | [**VcenterVchaIpSpec**](VcenterVchaIpSpec.md) | IP specification for the Management network.  This property was added in __vSphere API 6.7.1__. | 
**Ha** | [**VcenterVchaIpSpec**](VcenterVchaIpSpec.md) | IP specification for the HA network.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, then the second NIC of the Active Node of the VCHA cluster is not configured. | [optional] 
**Placement** | [**VcenterVchaPlacementInfo**](VcenterVchaPlacementInfo.md) | Contains the placement information of the active node.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, the request specified that placement information of the active node should not be included. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

