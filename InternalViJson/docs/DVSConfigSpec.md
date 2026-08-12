# Vcenter.ViJson.OpenApi.Model.DVSConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**ConfigVersion** | **string** | The version string of the configuration that this spec is trying to change.  This property is required in reconfiguring a switch and should be set to the same value as *DVSConfigInfo.configVersion*. This property is ignored during switch creation.  | [optional] 
**Name** | **string** | The name of the switch.  Must be unique in the parent folder.  | [optional] 
**NumStandalonePorts** | **int** | The number of standalone ports in the switch.  Standalone ports are ports that do not belong to any portgroup. If set to a number larger than number of existing standalone ports in the switch, new ports get created to meet the number. If set to a number smaller than the number of existing standalone ports, free ports (uplink ports excluded) are deleted to meet the number. If the set number cannot be met by deleting free standalone ports, a fault is raised.  | [optional] 
**MaxPorts** | **int** | Deprecated as of vSphere API 5.0 The default value of this property is maxint and there is no reason for users to change it to a lower value.  The maximum number of DistributedVirtualPorts allowed in the switch.  If specified in a reconfigure operation, this number cannot be smaller than the number of existing DistributedVirtualPorts.  | [optional] 
**UplinkPortPolicy** | [**DVSUplinkPortPolicy**](DVSUplinkPortPolicy.md) | The uplink port policy.  | [optional] 
**UplinkPortgroup** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The uplink portgroups.  Refers instances of *DistributedVirtualPortgroup*.  | [optional] 
**DefaultPortConfig** | [**DVPortSetting**](DVPortSetting.md) | The default configuration for ports.  | [optional] 
**Host** | [**List&lt;DistributedVirtualSwitchHostMemberConfigSpec&gt;**](DistributedVirtualSwitchHostMemberConfigSpec.md) | The host member specification.  A particular host should have only one entry in this array. Duplicate entries for the same host will raise a fault. The host version should be compatible with the version of *DistributedVirtualSwitch*. Use *DistributedVirtualSwitchManager.QueryDvsCheckCompatibility* to check for compatibility.  | [optional] 
**ExtensionKey** | **string** | The key of the extension registered by a remote server that controls the switch.  | [optional] 
**Description** | **string** | Set the description string of the switch.  | [optional] 
**Policy** | [**DVSPolicy**](DVSPolicy.md) | The usage policy of the switch.  | [optional] 
**VendorSpecificConfig** | [**List&lt;DistributedVirtualSwitchKeyedOpaqueBlob&gt;**](DistributedVirtualSwitchKeyedOpaqueBlob.md) | Set the opaque blob that stores vendor specific configuration.  | [optional] 
**Contact** | [**DVSContactInfo**](DVSContactInfo.md) | Set the human operator contact information.  | [optional] 
**SwitchIpAddress** | **string** | IP address for the switch, specified using IPv4 dot notation.  IPv6 address is not supported for this property. The utility of this address is defined by other switch features. switchIpAddress would be ignored when IPFIX collector uses IPv6.  | [optional] 
**DefaultProxySwitchMaxNumPorts** | **int** | The default host proxy switch maximum port number  | [optional] 
**InfrastructureTrafficResourceConfig** | [**List&lt;DvsHostInfrastructureTrafficResource&gt;**](DvsHostInfrastructureTrafficResource.md) | The host infrastructure traffic resource allocation specification.  Only the traffic class resource allocations identified in the list will be updated. The other traffic class resource allocations that are not specified will not change.  | [optional] 
**NetResourcePoolTrafficResourceConfig** | [**List&lt;DvsHostInfrastructureTrafficResource&gt;**](DvsHostInfrastructureTrafficResource.md) | The dynamic host infrastructure traffic resource allocation specification.  | [optional] 
**NetworkResourceControlVersion** | **string** | Indicates the Network Resource Control APIs that are supported on the switch.  Possible value can be of *DistributedVirtualSwitchNetworkResourceControlVersion_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

