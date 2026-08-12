# Vcenter.ViJson.OpenApi.Model.HostVirtualSwitch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the virtual switch.  Maximum length is 32 characters.  | 
**Key** | **string** | The virtual switch key.  | 
**NumPorts** | **int** | The number of ports that this virtual switch currently has.  | 
**NumPortsAvailable** | **int** | The number of ports that are available on this virtual switch.  There are a number of networking services that utilize a port on the virtual switch and are not accounted for in the Port array of a PortGroup. For example, each physical NIC attached to a virtual switch consumes one port. This property should be used when attempting to implement admission control for new services attaching to virtual switches.  | 
**Mtu** | **int** | The maximum transmission unit (MTU) associated with this virtual switch in bytes.  | [optional] 
**Portgroup** | **List&lt;string&gt;** | The list of port groups configured for this virtual switch.  | [optional] 
**Pnic** | **List&lt;string&gt;** | The set of physical network adapters associated with this bridge.  | [optional] 
**Spec** | [**HostVirtualSwitchSpec**](HostVirtualSwitchSpec.md) | The specification of this virtual switch.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

