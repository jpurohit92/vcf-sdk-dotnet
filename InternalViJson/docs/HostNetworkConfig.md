# Vcenter.ViJson.OpenApi.Model.HostNetworkConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vswitch** | [**List&lt;HostVirtualSwitchConfig&gt;**](HostVirtualSwitchConfig.md) | Virtual switches configured on the host.  | [optional] 
**ProxySwitch** | [**List&lt;HostProxySwitchConfig&gt;**](HostProxySwitchConfig.md) | Host proxy switches configured on the host.  | [optional] 
**Portgroup** | [**List&lt;HostPortGroupConfig&gt;**](HostPortGroupConfig.md) | Port groups configured on the host.  | [optional] 
**Pnic** | [**List&lt;PhysicalNicConfig&gt;**](PhysicalNicConfig.md) | Physical network adapters as seen by the primary operating system.  | [optional] 
**Vnic** | [**List&lt;HostVirtualNicConfig&gt;**](HostVirtualNicConfig.md) | Virtual network adapters configured for use by the host operating system network adapter.  | [optional] 
**ConsoleVnic** | [**List&lt;HostVirtualNicConfig&gt;**](HostVirtualNicConfig.md) | Virtual network adapters configured for use by the Service Console.  | [optional] 
**DnsConfig** | [**HostDnsConfig**](HostDnsConfig.md) | Deprecated as of vSphere API 5.5, which is moved to the default NetStackInstance.  Client-side DNS configuration for the host.  The DNS configuration is global to the entire host.  | [optional] 
**IpRouteConfig** | [**HostIpRouteConfig**](HostIpRouteConfig.md) | Deprecated as of vSphere API 5.5, which is moved to the default NetStackInstance.  IP route configuration of the host.  | [optional] 
**ConsoleIpRouteConfig** | [**HostIpRouteConfig**](HostIpRouteConfig.md) | IP route configuration of the service console.  | [optional] 
**RouteTableConfig** | [**HostIpRouteTableConfig**](HostIpRouteTableConfig.md) | Deprecated as of vSphere API 5.5, which is moved to the default NetStackInstance.  IP routing table configuration of the host.  | [optional] 
**Dhcp** | [**List&lt;HostDhcpServiceConfig&gt;**](HostDhcpServiceConfig.md) | Dynamic Host Control Protocol (DHCP) Service instances configured on the host.  | [optional] 
**Nat** | [**List&lt;HostNatServiceConfig&gt;**](HostNatServiceConfig.md) | Network address translation (NAT) Service instances configured on the host.  | [optional] 
**IpV6Enabled** | **bool** | Enable or disable IPv6 protocol on this system.  This property must be set by itself, no other property can accompany this change. Following the successful change, the system should be rebooted to have the change take effect.  | [optional] 
**NetStackSpec** | [**List&lt;HostNetworkConfigNetStackSpec&gt;**](HostNetworkConfigNetStackSpec.md) | The list of network stack instance spec  | [optional] 
**MigrationStatus** | **string** | Current status of NVDS to VDS migration.  See *HostNetworkConfig*.*HostNetworkConfigMigrationStatus_enum* for supported values.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

