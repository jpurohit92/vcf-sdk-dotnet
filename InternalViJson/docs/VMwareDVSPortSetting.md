# Vcenter.ViJson.OpenApi.Model.VMwareDVSPortSetting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blocked** | [**BoolPolicy**](BoolPolicy.md) | Indicates whether this port is blocked.  If a port is blocked, packet forwarding is stopped.  | [optional] 
**VmDirectPathGen2Allowed** | [**BoolPolicy**](BoolPolicy.md) | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Indicates whether this port is allowed to do VMDirectPath Gen2 network passthrough.  Direct path capability is defined at host, switch, and device levels. See the &lt;code&gt;vmDirectPathGen2Supported&lt;/code&gt; properties on the *DVSFeatureCapability*, *HostCapability*, *PhysicalNic*, and *VirtualEthernetCardOption* objects.  | [optional] 
**InShapingPolicy** | [**DVSTrafficShapingPolicy**](DVSTrafficShapingPolicy.md) | Network shaping policy for controlling throughput of inbound traffic.  | [optional] 
**OutShapingPolicy** | [**DVSTrafficShapingPolicy**](DVSTrafficShapingPolicy.md) | Network shaping policy for controlling throughput of outbound traffic.  | [optional] 
**VendorSpecificConfig** | [**DVSVendorSpecificConfig**](DVSVendorSpecificConfig.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 
**NetworkResourcePoolKey** | [**StringPolicy**](StringPolicy.md) | Deprecated as of vSphere API 6.0 Use *DVPortgroupConfigInfo.vmVnicNetworkResourcePoolKey* instead to reference the virtual NIC network resource pool.  The key of user defined network resource pool to be associated with a port.  The default value for this property is \&quot;-1\&quot;, indicating that this port is not associated with any network resource pool.  | [optional] 
**FilterPolicy** | [**DvsFilterPolicy**](DvsFilterPolicy.md) | Configuration for Network Filter Policy.  | [optional] 
**Vlan** | [**VmwareDistributedVirtualSwitchVlanSpec**](VmwareDistributedVirtualSwitchVlanSpec.md) | The VLAN Specification of the port.  | [optional] 
**QosTag** | [**IntPolicy**](IntPolicy.md) | Deprecated as of vSphere API 5.0.  The Quality Of Service tagging of the port.  | [optional] 
**UplinkTeamingPolicy** | [**VmwareUplinkPortTeamingPolicy**](VmwareUplinkPortTeamingPolicy.md) | The uplink teaming policy.  This property is ignored for uplink ports.  | [optional] 
**SecurityPolicy** | [**DVSSecurityPolicy**](DVSSecurityPolicy.md) | Deprecated as of vSphere API 6.7, use *DVSMacManagementPolicy* instead to specify the security policy.  The security policy.  | [optional] 
**IpfixEnabled** | [**BoolPolicy**](BoolPolicy.md) | True if ipfix monitoring is enabled.  To successfully enable ipfix monitoring, the switch must have an assigned *IP address* and an appropriately populated *ipfix configuration* that specifies a collector IP address and port. Since the 9.1 release, ipfix monitoring can not be enabled on uplink portgroups.  | [optional] 
**TxUplink** | [**BoolPolicy**](BoolPolicy.md) | If true, a copy of packets sent to the switch will always be forwarded to an uplink in addition to the regular packet forwarded done by the switch.  | [optional] 
**LacpPolicy** | [**VMwareUplinkLacpPolicy**](VMwareUplinkLacpPolicy.md) | Deprecated as of vSphere API 5.5, use *VmwareDistributedVirtualSwitch.UpdateDVSLacpGroupConfig_Task* and *VMwareDVSConfigInfo.lacpGroupConfig* instead.  Link Aggregation Control Protocol policy.  This policy is ignored on non-uplink portgroups. Setting this policy at port level is not supported.  | [optional] 
**MacManagementPolicy** | [**DVSMacManagementPolicy**](DVSMacManagementPolicy.md) | The MAC learning policy.  | [optional] 
**VNI** | [**IntPolicy**](IntPolicy.md) | The VNI number of overlay logical switch, which is used by NSX portgroup.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

