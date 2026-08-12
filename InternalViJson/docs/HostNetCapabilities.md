# Vcenter.ViJson.OpenApi.Model.HostNetCapabilities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanSetPhysicalNicLinkSpeed** | **bool** | The flag to indicate whether or not a physical network adapter&#39;s link speed and duplex settings can be changed through this API.  For a hosted product, the host uses its physical network adapters for network connectivity. Configuration of link speed is done through regular host operations. In ESX Server, the configuration can be changed through this API.  | 
**SupportsNicTeaming** | **bool** | The flag to indicate whether or not network adapter teaming is available.  Multiple network adapters can be bridged to a virtual switch through a BondBridge. Also, network adapter teaming policies such as failover order and detection are enabled.  | 
**NicTeamingPolicy** | **List&lt;string&gt;** | The available teaming policies if the platform supports network adapter teaming.  | [optional] 
**SupportsVlan** | **bool** | The flag to indicate whether or not VLANs can be configured on PortGroups attached to VirtualSwitch objects.  This allows VLANs for virtual machines without requiring special VLAN capable hardware switches.  | 
**UsesServiceConsoleNic** | **bool** | The flag to indicate whether or not a service console network adapter is used or required.  This means that the system software has two TCP/IP stacks. As a result, at least two types of VirtualNics may be created - - the normal VirtualNic and the service console VirtualNic. If this is not set, then only the VirtualNic type is supported.  | 
**SupportsNetworkHints** | **bool** | The flag to indicate whether or not the host is able to support the querying of network hints.  | 
**MaxPortGroupsPerVswitch** | **int** | The maximum number of port groups supported per virtual switch.  This property will not be set if this value is unlimited.  | [optional] 
**VswitchConfigSupported** | **bool** | The flag to indicate whether virtual switch configuration is supported.  This means that operations to add, remove, update virtual switches are supported.  | 
**VnicConfigSupported** | **bool** | The flag to indicate whether Virtual NIC configuration is supported.  This means that operations to add, remove, update virtualNic are supported.  | 
**IpRouteConfigSupported** | **bool** | The flag to indicate whether ip route configuration for the host is supported.  | 
**DnsConfigSupported** | **bool** | The flag to indicate whether DNS configuration for the host is supported.  | 
**DhcpOnVnicSupported** | **bool** | This flag indicates whether or not the host is able to support dhcp configuration for vnics.  | 
**IpV6Supported** | **bool** | The flag to indicate whether the host is capable of communicating using ipv6 protocol  | 
**BackupNfcNiocSupported** | **bool** | The flag to indicate whether the host supports Backup NFC NIOC system traffic, Unset means Backup NFC NIOC system traffic is not supported.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

