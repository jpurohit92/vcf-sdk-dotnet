# Vcenter.ViJson.OpenApi.Model.HostVirtualNicConnection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Portgroup** | **string** | Name of the portgroup to which the virtual nic is connected to.  If this parameter is set, use a virtual nic connected to a legacy portgroup.  | [optional] 
**DvPort** | [**DistributedVirtualSwitchPortConnection**](DistributedVirtualSwitchPortConnection.md) | Identifier for the DistributedVirtualPort.  If the virtual nic is to be connected to a DVS, \\#dvPort will be set instead of #portgroup  | [optional] 
**OpNetwork** | [**HostVirtualNicOpaqueNetworkSpec**](HostVirtualNicOpaqueNetworkSpec.md) | Identifier for the opaqueNetworkSpec virtual nic connected to.  If the virtual nic is to be connected to a logicSwitch, \\#opNetwork will be set instead of #portgroup and #dvPort  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

