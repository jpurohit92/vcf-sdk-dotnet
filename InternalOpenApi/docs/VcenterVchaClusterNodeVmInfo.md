# Vcenter.Automation.OpenApi.Model.VcenterVchaClusterNodeVmInfo
The Vcenter.Vcha.Cluster.NodeVmInfo schema contains information to describe the Virtual Machine of a node of a VCHA cluster.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | **string** | The identifier of the virtual machine of the VCHA node.  This property was added in __vSphere API 6.7.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;VirtualMachine:VCenter&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;VirtualMachine:VCenter&#x60;. | 
**BiosUuid** | **string** | BIOS UUID for the node.  This property was added in __vSphere API 6.7.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

