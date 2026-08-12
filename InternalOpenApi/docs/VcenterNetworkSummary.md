# Vcenter.Automation.OpenApi.Model.VcenterNetworkSummary
The Vcenter.Network.Summary schema contains commonly used information about a network.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | Identifier of the network.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | 
**Name** | **string** | Name of the network. | 
**Type** | **string** | Type (Type) of the vCenter Server network.  Possible values:   - &#x60;STANDARD_PORTGROUP&#x60;: vSphere standard portgroup (created and managed on ESX)   - &#x60;DISTRIBUTED_PORTGROUP&#x60;: Distributed virtual portgroup (created and managed through vCenter)   - &#x60;OPAQUE_NETWORK&#x60;: A network whose configuration is managed outside of vSphere. The identifier and name of the network is made available through vSphere so that host and virtual machine virtual ethernet devices can connect to them.   For more information see: *Vcenter.Network.Type*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

