# Vcenter.ViJson.OpenApi.Model.DVPortgroupConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**ConfigVersion** | **string** | Version string of the configuration that this spec is trying to change.  This property is required in reconfiguring a portgroup and should be set to the same value as the *DVPortgroupConfigInfo.configVersion*. This property is ignored in creating a portgroup if set.  | [optional] 
**Name** | **string** | Name of the portgroup.  | [optional] 
**NumPorts** | **int** | Number of ports in the portgroup.  Setting this number larger than the number of existing ports in the portgroup causes new ports to be added to the portgroup to meet the number. Setting this property smaller than the number of existing ports deletes the free ports from the portgroup. If the number cannot be met by deleting free ports, a fault is raised. If new ports are added to the portgroup, they are also added to the switch. For portgroups of type ephemeral this property is ignored.  | [optional] 
**PortNameFormat** | **string** | Format of the name of the ports when ports are created in the portgroup.  For details see *DVPortgroupConfigInfo.portNameFormat*.  | [optional] 
**DefaultPortConfig** | [**DVPortSetting**](DVPortSetting.md) | Default network setting for all the ports in the portgroup.  | [optional] 
**Description** | **string** | Description of the portgroup.  | [optional] 
**Type** | **string** | Type of portgroup.  See *DistributedVirtualPortgroup*.*DistributedVirtualPortgroupPortgroupType_enum* for possible values.  | [optional] 
**BackingType** | **string** | Backing type of portgroup.  See *DistributedVirtualPortgroup*.*DistributedVirtualPortgroupBackingType_enum* for possible values. The default value is \&quot;standard\&quot;  | [optional] 
**Scope** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Deprecated as of vSphere API 5.5.  Eligible entities that can connect to the port.  See *DVPortgroupConfigInfo*.*DVPortgroupConfigInfo.scope*.  Refers instances of *ManagedEntity*.  | [optional] 
**Policy** | [**DVPortgroupPolicy**](DVPortgroupPolicy.md) | Portgroup policy.  | [optional] 
**VendorSpecificConfig** | [**List&lt;DistributedVirtualSwitchKeyedOpaqueBlob&gt;**](DistributedVirtualSwitchKeyedOpaqueBlob.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 
**AutoExpand** | **bool** | If set to true, this property ignores the limit on the number of ports in the portgroup.  When a Virtual Machine/Host tries to connect to the portgroup and there are no free ports available in the portgroup, new ports will be automatically added to the portgroup. The flag is currently supported only for static portgroups.  Setting this property to true makes the portgroup a potential candidate for auto-shrink. Once the portgroup has auto-expanded then its disconnected ports are likely to be deleted automatically, as a part of auto-shrink step, if there are more than certain number of free ports. If the portgroup never auto-expanded, then it will never lose any free ports.  | [optional] 
**VmVnicNetworkResourcePoolKey** | **string** | The key of virtual NIC network resource pool to be associated with a portgroup.  Setting this property to \&quot;-1\&quot;, would mean that this portgroup is not associated with any virtual NIC network resource pool.  | [optional] 
**TransportZoneUuid** | **string** | The UUID of transport zone to be associated with a NSX portgroup.  | [optional] 
**TransportZoneName** | **string** | The name of transport zone to be associated with a NSX portgroup.  | [optional] 
**LogicalSwitchUuid** | **string** | The logical switch UUID, which is used by NSX portgroup  | [optional] 
**SegmentId** | **string** | The segment ID of logical switch  | [optional] 
**SubnetId** | **string** | The subnet ID of logical switch  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**NsxConfig** | [**DVPortgroupNsxConfig**](DVPortgroupNsxConfig.md) | The NSX-related configurations.  Update semantics: This structure uses an override model: the provided values replace existing ones, and omitted or unset properties are cleared.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

