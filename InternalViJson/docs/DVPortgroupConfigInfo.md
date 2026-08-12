# Vcenter.ViJson.OpenApi.Model.DVPortgroupConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key of the portgroup.  | 
**Name** | **string** | Name of the portgroup.  | 
**NumPorts** | **int** | Number of ports in the portgroup.  | 
**DistributedVirtualSwitch** | [**ManagedObjectReference**](ManagedObjectReference.md) | Distributed virtual switch that the portgroup is defined on.  This property should always be set unless the user&#39;s setting does not have System.Read privilege on the object referred to by this property.  Refers instance of *DistributedVirtualSwitch*.  | [optional] 
**DefaultPortConfig** | [**DVPortSetting**](DVPortSetting.md) | Common network setting for all the ports in the portgroup.  | [optional] 
**Description** | **string** | Description of the portgroup.  | [optional] 
**Type** | **string** | Type of portgroup.  See *DistributedVirtualPortgroup*.*DistributedVirtualPortgroupPortgroupType_enum* for possible values.  | 
**BackingType** | **string** | Backing type of portgroup.  See *DistributedVirtualPortgroup*.*DistributedVirtualPortgroupBackingType_enum* for possible values. The default value is \&quot;standard\&quot;  | [optional] 
**Policy** | [**DVPortgroupPolicy**](DVPortgroupPolicy.md) | Portgroup policy.  | 
**PortNameFormat** | **string** | If set, a name will be automatically generated based on this format string for a port when it is created in or moved into the portgroup.  The format string can contain meta tags that will be resolved to the corresponding values in generating a name, if applicable for the port at the time of name generation.  To insert a meta tag in the format string, enclose the names defined as meta tag names inside angle brackets. See *DistributedVirtualPortgroupMetaTagName_enum* for a list of currently available meta tags. For example, \&quot;redNetwork-&amp;lt;portIndex&amp;gt;\&quot; and \&quot;&amp;lt;dvsName&amp;gt;-pnic&amp;lt;portIndex&amp;gt;\&quot; result in generated port names like \&quot;redNetwork-2\&quot; and \&quot;switch-pnic3\&quot;.  If a meta tag is recognized, but there is no applicable value, the tag will be expanded to empty string. If an arbitrary name appears inside a \&quot;&amp;lt;&amp;gt;\&quot; pair and is not recognized as one of the defined meta tags, the substring is treated as-is and appear unchanged in the generated name.  To prevent a meta tag from being expanded, prefix the meta tag with a &#39;\\\\&#39; (backslash). For example, the format string \&quot;abc\\\\&amp;lt;portIndex&amp;gt;def\&quot; results in the generated port name \&quot;abc&amp;lt;portIndex&amp;gt;def\&quot;.  | [optional] 
**Scope** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Deprecated as of vSphere API 5.5.  Eligible entities that can connect to the portgroup.  If unset, there is no restriction on which entity can connect to the portgroup. If set, only the entities in the specified list or their child entities are allowed to connect to the portgroup. If scopes are defined at both port and portgroup level, they are taken as an \&quot;AND\&quot; relationship. If such a relationship doesn&#39;t make sense, the reconfigure operation will raise an exception.  Refers instances of *ManagedEntity*.  | [optional] 
**VendorSpecificConfig** | [**List&lt;DistributedVirtualSwitchKeyedOpaqueBlob&gt;**](DistributedVirtualSwitchKeyedOpaqueBlob.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 
**ConfigVersion** | **string** | Configuration version number.  | [optional] 
**AutoExpand** | **bool** | If set to true, this property ignores the limit on the number of ports in the portgroup.  When a Virtual Machine/Host tries to connect to the portgroup and there are no free ports available in the portgroup, new ports will be automatically added to the portgroup. The flag is currently supported only for static portgroups.  When this property is set to true, the portgroup becomes a potential candidate for auto-shrink. Once the portgroup has auto-expanded then its disconnected ports are likely to be deleted automatically, as a part of auto-shrink step, if there are more than certain number of free ports. If the portgroup never auto-expanded, then it will never lose any free ports.  | [optional] 
**VmVnicNetworkResourcePoolKey** | **string** | The key of virtual NIC network resource pool to be associated with a portgroup.  The default value for this property is unset, indicating that this portgroup is not associated with any virtual NIC network resource pool. To clear the value of this property and revert to unset, set the *DVPortgroupConfigSpec.vmVnicNetworkResourcePoolKey* to \&quot;-1\&quot; in an update operation.  | [optional] 
**Uplink** | **bool** | Indicates whether the portgroup is an uplink portroup.  | [optional] 
**TransportZoneUuid** | **string** | The UUID of transport zone to be associated with a NSX portgroup.  | [optional] 
**TransportZoneName** | **string** | The name of transport zone to be associated with a NSX portgroup.  | [optional] 
**LogicalSwitchUuid** | **string** | The logical switch UUID, which is used by NSX portgroup  | [optional] 
**SegmentId** | **string** | The segment ID of logical switch  | [optional] 
**SubnetId** | **string** | ID of the VPC Subnet when the DVPG is backed by a VPC Subnet  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**NsxConfig** | [**DVPortgroupNsxConfig**](DVPortgroupNsxConfig.md) | The NSX-related configurations.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

