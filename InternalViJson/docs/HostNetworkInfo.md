# Vcenter.ViJson.OpenApi.Model.HostNetworkInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vswitch** | [**List&lt;HostVirtualSwitch&gt;**](HostVirtualSwitch.md) | Virtual switches configured on the host.  | [optional] 
**ProxySwitch** | [**List&lt;HostProxySwitch&gt;**](HostProxySwitch.md) | Proxy switches configured on the host.  | [optional] 
**Portgroup** | [**List&lt;HostPortGroup&gt;**](HostPortGroup.md) | Port groups configured on the host.  | [optional] 
**Pnic** | [**List&lt;PhysicalNic&gt;**](PhysicalNic.md) | Physical network adapters as seen by the primary operating system.  | [optional] 
**RdmaDevice** | [**List&lt;HostRdmaDevice&gt;**](HostRdmaDevice.md) | Remote direct memory access devices, if any are present on the host.  | [optional] 
**Vnic** | [**List&lt;HostVirtualNic&gt;**](HostVirtualNic.md) | Virtual network adapters configured on the host (hosted products) or the vmkernel.  In the hosted architecture, these network adapters are used by the host to communicate with the virtual machines running on that host. In the VMkernel architecture, these virtual network adapters provide the ESX Server with external network access through a virtual switch that is bridged to a physical network adapter. The VMkernel uses these network adapters for features such as VMotion, NAS, iSCSI, and remote MKS connections.  | [optional] 
**ConsoleVnic** | [**List&lt;HostVirtualNic&gt;**](HostVirtualNic.md) | Virtual network adapters configured for use by the service console.  The service console uses this network access for system management and bootstrapping services like network boot. The two sets of virtual network adapters are mutually exclusive. A virtual network adapter in this list cannot be used for things like VMotion. Likewise, a virtual network adapter in the other list cannot be used by the service console.  | [optional] 
**DnsConfig** | [**HostDnsConfig**](HostDnsConfig.md) | Deprecated as of vSphere API 5.5, which is moved to each NetStackInstance. For this property in NetworkInfo, Get operation will only return its value of default NetStackInstance.  Client-side DNS configuration.  | [optional] 
**IpRouteConfig** | [**HostIpRouteConfig**](HostIpRouteConfig.md) | Deprecated as of vSphere API 5.5, which is moved to each NetStackInstance. For this property in NetworkInfo, Get operation will only return its value of default NetStackInstance.  IP route configuration.  | [optional] 
**ConsoleIpRouteConfig** | [**HostIpRouteConfig**](HostIpRouteConfig.md) | IP route configuration of the service console.  | [optional] 
**RouteTableInfo** | [**HostIpRouteTableInfo**](HostIpRouteTableInfo.md) | Deprecated as of vSphere API 5.5, which is moved to each NetStackInstance. For this property in NetworkInfo, Get operation will only return its value of default NetStackInstance.  IP routing table  | [optional] 
**Dhcp** | [**List&lt;HostDhcpService&gt;**](HostDhcpService.md) | DHCP Service instances configured on the host.  | [optional] 
**Nat** | [**List&lt;HostNatService&gt;**](HostNatService.md) | NAT service instances configured on the host.  | [optional] 
**IpV6Enabled** | **bool** | Enable or disable IPv6 protocol on this system.  | [optional] 
**AtBootIpV6Enabled** | **bool** | If true then dual IPv4/IPv6 stack enabled else IPv4 only.  | [optional] 
**NetStackInstance** | [**List&lt;HostNetStackInstance&gt;**](HostNetStackInstance.md) | List of NetStackInstances  | [optional] 
**OpaqueSwitch** | [**List&lt;HostOpaqueSwitch&gt;**](HostOpaqueSwitch.md) | List of opaque switches configured on the host.  | [optional] 
**OpaqueNetwork** | [**List&lt;HostOpaqueNetworkInfo&gt;**](HostOpaqueNetworkInfo.md) | List of opaque networks  | [optional] 
**NsxTransportNodeId** | **string** | The nsx transport node Id  | [optional] 
**NvdsToVdsMigrationRequired** | **bool** | Whether NSX N-VDS to VDS migration is required  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**MigrationStatus** | **string** | Current status of NVDS to VDS migration.  See *HostNetworkConfig*.*HostNetworkConfigMigrationStatus_enum* for supported values.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

