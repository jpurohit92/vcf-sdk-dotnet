# Vcenter.ViJson.OpenApi.Model.VMwareDVSConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Generated UUID of the switch.  Unique across vCenter Server inventory and instances.  | 
**Name** | **string** | Name of the switch.  | 
**NumStandalonePorts** | **int** | Number of standalone ports in the switch.  Standalone ports are ports that do not belong to any portgroup.  | 
**NumPorts** | **int** | Current number of ports, not including conflict ports.  | 
**MaxPorts** | **int** | Maximum number of ports allowed in the switch, not including conflict ports.  | 
**UplinkPortPolicy** | [**DVSUplinkPortPolicy**](DVSUplinkPortPolicy.md) | Uplink port policy.  | 
**UplinkPortgroup** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of uplink portgroups.  When adding host members, the server uses the *DVSConfigInfo.uplinkPortPolicy* to create a number of uplink ports for the host. If portgroups are shown here, those uplink ports will be added to the portgroups, with uplink ports evenly spread among the portgroups.  Refers instances of *DistributedVirtualPortgroup*.  | [optional] 
**DefaultPortConfig** | [**DVPortSetting**](DVPortSetting.md) | Default configuration for the ports in the switch, if the port does not inherit configuration from the parent portgroup or has its own configuration.  | 
**Host** | [**List&lt;DistributedVirtualSwitchHostMember&gt;**](DistributedVirtualSwitchHostMember.md) | Hosts that join the switch.  | [optional] 
**ProductInfo** | [**DistributedVirtualSwitchProductSpec**](DistributedVirtualSwitchProductSpec.md) | Vendor, product, and version information for the implementation module of the switch.  | 
**TargetInfo** | [**DistributedVirtualSwitchProductSpec**](DistributedVirtualSwitchProductSpec.md) | Intended vendor, product, and version information for the implementation module of the switch.  | [optional] 
**ExtensionKey** | **string** | Key of the extension registered by the remote server that controls the switch.  | [optional] 
**VendorSpecificConfig** | [**List&lt;DistributedVirtualSwitchKeyedOpaqueBlob&gt;**](DistributedVirtualSwitchKeyedOpaqueBlob.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 
**Policy** | [**DVSPolicy**](DVSPolicy.md) | Usage policy of the switch.  | [optional] 
**Description** | **string** | Description string for the switch.  | [optional] 
**ConfigVersion** | **string** | Version string of the configuration.  | 
**Contact** | [**DVSContactInfo**](DVSContactInfo.md) | Human operator contact information.  | 
**SwitchIpAddress** | **string** | IP address for the switch, specified using IPv4 dot notation.  The utility of this address is defined by other switch features.  | [optional] 
**CreateTime** | **DateTime** | Create time of the switch.  | 
**NetworkResourceManagementEnabled** | **bool** | Boolean to indicate if network I/O control is enabled on the switch.  | 
**DefaultProxySwitchMaxNumPorts** | **int** | Default host proxy switch maximum port number  | [optional] 
**HealthCheckConfig** | [**List&lt;DVSHealthCheckConfig&gt;**](DVSHealthCheckConfig.md) | VDS health check configuration.  | [optional] 
**InfrastructureTrafficResourceConfig** | [**List&lt;DvsHostInfrastructureTrafficResource&gt;**](DvsHostInfrastructureTrafficResource.md) | Host infrastructure traffic class resource configuration.  | [optional] 
**NetResourcePoolTrafficResourceConfig** | [**List&lt;DvsHostInfrastructureTrafficResource&gt;**](DvsHostInfrastructureTrafficResource.md) | Dynamic Host infrastructure traffic class resource configuration.  | [optional] 
**NetworkResourceControlVersion** | **string** | Network resource control version of the switch.  Possible value can be of *DistributedVirtualSwitchNetworkResourceControlVersion_enum*.  | [optional] 
**VmVnicNetworkResourcePool** | [**List&lt;DVSVmVnicNetworkResourcePool&gt;**](DVSVmVnicNetworkResourcePool.md) | The Virtual NIC network resource pool information for the switch.  | [optional] 
**PnicCapacityRatioForReservation** | **int** | The percentage of physical nic link speed *PhysicalNicLinkInfo.speedMb* available for infrastructure traffic reservation.  If this value is 75, then for a 1Gbps physical nic, only 750Mbps is allowed for all infrastructure traffic reservations.  | [optional] 
**VspanSession** | [**List&lt;VMwareVspanSession&gt;**](VMwareVspanSession.md) | The Distributed Port Mirroring sessions in the switch.  | [optional] 
**PvlanConfig** | [**List&lt;VMwareDVSPvlanMapEntry&gt;**](VMwareDVSPvlanMapEntry.md) | The PVLAN configured in the switch.  | [optional] 
**MaxMtu** | **int** | The maximum MTU in the switch.  | 
**LinkDiscoveryProtocolConfig** | [**LinkDiscoveryProtocolConfig**](LinkDiscoveryProtocolConfig.md) | See *LinkDiscoveryProtocolConfig*.  | [optional] 
**IpfixConfig** | [**VMwareIpfixConfig**](VMwareIpfixConfig.md) | Configuration for ipfix monitoring of the switch traffic.  This must be set before ipfix monitoring can be enabled for the switch, or for any portgroup or port of the switch.  See also *VMwareDVSPortSetting.ipfixEnabled*.  | [optional] 
**LacpGroupConfig** | [**List&lt;VMwareDvsLacpGroupConfig&gt;**](VMwareDvsLacpGroupConfig.md) | The Link Aggregation Control Protocol groups in the switch.  | [optional] 
**LacpApiVersion** | **string** | The Link Aggregation Control Protocol group version in the switch.  See *VMwareDvsLacpApiVersion_enum* for valid values.  | [optional] 
**MulticastFilteringMode** | **string** | The Multicast Filtering mode in the switch.  See *VMwareDvsMulticastFilteringMode_enum* for valid values.  | [optional] 
**NetworkOffloadSpecId** | **string** | Indicate the ID of NetworkOffloadSpec used in the switch.  ID \&quot;None\&quot; means that network offload is not allowed in the switch.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NetworkOffloadConfig** | [**VmwareDistributedVirtualSwitchNetworkOffloadConfig**](VmwareDistributedVirtualSwitchNetworkOffloadConfig.md) | The network offload specific configuration of the switch.  It is only set when network offload is allowed (*VMwareDVSConfigInfo.networkOffloadSpecId* is not \&quot;None\&quot;).  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**RealTimeConfig** | [**VmwareDistributedVirtualSwitchRealTimeConfig**](VmwareDistributedVirtualSwitchRealTimeConfig.md) | The real-time specific configuration of the switch.  ***Since:*** vSphere API Release 8.0.3.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

