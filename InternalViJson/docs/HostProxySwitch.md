# Vcenter.ViJson.OpenApi.Model.HostProxySwitch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DvsUuid** | **string** | The uuid of the DistributedVirtualSwitch that the HostProxySwitch is a part of.  | 
**DvsName** | **string** | The name of the DistributedVirtualSwitch that the HostProxySwitch is part of.  | 
**Key** | **string** | The proxy switch key.  | 
**NumPorts** | **int** | The number of ports that this switch currently has.  | 
**ConfigNumPorts** | **int** | The configured number of ports that this switch has.  If configured number of ports is changed, a host reboot is required for the new value to take effect.  | [optional] 
**NumPortsAvailable** | **int** | The number of ports that are available on this virtual switch.  | 
**UplinkPort** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The list of ports that can be potentially used by physical nics.  This property contains the keys and names of such ports.  | [optional] 
**Mtu** | **int** | The maximum transmission unit (MTU) associated with this switch in bytes.  | [optional] 
**Pnic** | **List&lt;string&gt;** | The set of physical network adapters associated with this switch.  | [optional] 
**Spec** | [**HostProxySwitchSpec**](HostProxySwitchSpec.md) | The specification of the switch.  | 
**HostLag** | [**List&lt;HostProxySwitchHostLagConfig&gt;**](HostProxySwitchHostLagConfig.md) | The Link Aggregation Control Protocol group and Uplink ports in the group.  | [optional] 
**NetworkReservationSupported** | **bool** | Indicates whether network reservation is supported on this switch  | [optional] 
**NsxtEnabled** | **bool** | Indicate whether NSX-T is enabled on this switch  | [optional] 
**EnsEnabled** | **bool** | Is ENS enabled on this switch  | [optional] 
**EnsInterruptEnabled** | **bool** | Is ENS interrupt mode enabled on this switch  | [optional] 
**TransportZones** | [**List&lt;DistributedVirtualSwitchHostMemberTransportZoneInfo&gt;**](DistributedVirtualSwitchHostMemberTransportZoneInfo.md) | Transport Zones this switch joined  | [optional] 
**NsxUsedUplinkPort** | **List&lt;string&gt;** | Uplink port names used by NSX-T  | [optional] 
**NsxtStatus** | **string** | NSX-T proxy switch status  | [optional] 
**NsxtStatusDetail** | **string** | Additional information regarding the NSX-T proxy switch status  | [optional] 
**EnsInfo** | [**HostProxySwitchEnsInfo**](HostProxySwitchEnsInfo.md) | ENS Status From VmKernel.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NetworkOffloadingEnabled** | **bool** | Indicate if network offloading is enabled on the proxy switch of this host.  Unset implies that network offloading is disabled.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**HostUplinkState** | [**List&lt;DistributedVirtualSwitchHostMemberHostUplinkState&gt;**](DistributedVirtualSwitchHostMemberHostUplinkState.md) | Indicates the runtime state of uplinks on the host.  Only set when *HostProxySwitch.networkOffloadingEnabled* is true.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**AutoDeployOwned** | **bool** | A flag indicating whether the VDS is created specifically for vSphere Auto Deploy on this host.  This is a temporary switch created by the ESX network plugin to restore the network connectivity to the vCenter. If this flag is not set, it implies that it is not created for vSphere Auto Deploy.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**HostPerfNicOffloadState** | [**DistributedVirtualSwitchHostMemberHostPerfNicOffloadState**](DistributedVirtualSwitchHostMemberHostPerfNicOffloadState.md) | Indicates the runtime state of performance NIC offloading on the host.  If unset, performance NIC offloading is considered disabled.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**TeplessMode** | **bool** | Indicates whether this host member is configured to operate in NSX tepless mode.  Tepless mode refers to a specific NSX overlay network configuration where the host does not have a Virtual Tunnel End Point (VTEP). This property is only effective when *HostProxySwitch.nsxtEnabled* is true. If this property is unset, the host member is not in NSX tepless mode.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

