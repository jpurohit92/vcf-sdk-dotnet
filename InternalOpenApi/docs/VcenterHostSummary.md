# Vcenter.Automation.OpenApi.Model.VcenterHostSummary
The Vcenter.Host.Summary schema contains commonly used information about a host in vCenter Server.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Identifier of the host.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**Name** | **string** | Name of the host. | 
**ConnectionState** | **string** | Connection status of the host  Possible values:   - &#x60;CONNECTED&#x60;: Host is connected to the vCenter Server   - &#x60;DISCONNECTED&#x60;: Host is disconnected from the vCenter Server   - &#x60;NOT_RESPONDING&#x60;: VirtualCenter is not receiving heartbeats from the server. The state automatically changes to connected once heartbeats are received again.   For more information see: *Vcenter.Host.ConnectionState*. | 
**PowerState** | **string** | Power state of the host  Possible values:   - &#x60;POWERED_ON&#x60;: The host is powered on. A host that is entering standby mode is also in this state.   - &#x60;POWERED_OFF&#x60;: The host was specifically powered off by the user through vCenter server. This state is not a certain state, because after vCenter server issues the command to power off the host, the host might crash, or kill all the processes but fail to power off.   - &#x60;STANDBY&#x60;: The host was specifically put in standby mode, either explicitly by the user, or automatically by DPM. This state is not a certain state, because after VirtualCenter issues the command to put the host in standby state, the host might crash, or kill all the processes but fail to enter standby mode. A host that is exiting standby mode is also in this state.   For more information see: *Vcenter.Host.PowerState*.  This property is optional and it is only relevant when the value of connection_state is *Vcenter.Host.ConnectionState.CONNECTED*. | [optional] 
**HostUuid** | **string** | UUID of the host. Maps to \&quot;UUID\&quot; in SMBIOS: System Information (Type 1) and offset 08h  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

