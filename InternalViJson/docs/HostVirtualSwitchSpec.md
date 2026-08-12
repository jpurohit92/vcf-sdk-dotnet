# Vcenter.ViJson.OpenApi.Model.HostVirtualSwitchSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumPorts** | **int** | The number of ports that this virtual switch is configured to use.  Changing this setting does not take effect until the next reboot. The maximum value is 1024, although other constraints, such as memory limits, may establish a lower effective limit.  | 
**Bridge** | [**HostVirtualSwitchBridge**](HostVirtualSwitchBridge.md) | The bridge specification describes how physical network adapters can be bridged to a virtual switch.  | [optional] 
**Policy** | [**HostNetworkPolicy**](HostNetworkPolicy.md) | The virtual switch policy specification.  This has a lower precedence than PortGroup. If the policy property is not set and you are creating a virtual switch, then a default policy property setting is used. If the policy property is not set and you are updating a virtual switch, then the policy will be unchanged.  | [optional] 
**Mtu** | **int** | The maximum transmission unit (MTU) of the virtual switch in bytes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

