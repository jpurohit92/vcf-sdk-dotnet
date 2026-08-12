# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchHostMemberConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | ESXi host.  This property should always be set unless the user&#39;s setting does not have System.Read privilege on the object referred to by this property.  Refers instance of *HostSystem*.  | [optional] 
**MaxProxySwitchPorts** | **int** | Maximum number of ports than can be created in the proxy switch.  _ESXi 5.0 and earlier hosts_: If you change the maximum number of ports, you must reboot the host for the new value to take effect.  | 
**VendorSpecificConfig** | [**List&lt;DistributedVirtualSwitchKeyedOpaqueBlob&gt;**](DistributedVirtualSwitchKeyedOpaqueBlob.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 
**Backing** | [**DistributedVirtualSwitchHostMemberBacking**](DistributedVirtualSwitchHostMemberBacking.md) | Host membership backing, specifying physical NIC, portgroup, and port bindings for the proxy switch.  | 
**NsxSwitch** | **bool** | Indicate whether the proxy switch is used by NSX on this particular host member of the VDS.  | [optional] 
**EnsEnabled** | **bool** | Indicate if ENS is enabled for this particular host member of the VDS.  It is read only.  | [optional] 
**EnsInterruptEnabled** | **bool** | Indicate if ENS interrupt mode is enabled for this particular host member of the VDS.  It is read only.  | [optional] 
**TransportZones** | [**List&lt;DistributedVirtualSwitchHostMemberTransportZoneInfo&gt;**](DistributedVirtualSwitchHostMemberTransportZoneInfo.md) | Indicate which transport zones this host joins by this VDS.  | [optional] 
**NsxtUsedUplinkNames** | **List&lt;string&gt;** | Indicate which uplink ports are used by NSX-T.  | [optional] 
**NetworkOffloadingEnabled** | **bool** | Indicate if network offloading is enabled for this particular host member of the VDS.  Unset implies that network offloading is disabled.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**TeplessMode** | **bool** | Indicates whether this host member is configured to operate in NSX tepless mode.  Tepless mode refers to a specific NSX overlay network configuration where the host does not have a Virtual Tunnel End Point (VTEP). This property is only effective when *DistributedVirtualSwitchHostMemberConfigInfo.nsxSwitch* is true. If this property is unset, the host member is not in NSX tepless mode.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

