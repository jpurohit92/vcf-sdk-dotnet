# Vcenter.ViJson.OpenApi.Model.NetworkProfile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Indicates whether the profile is enabled.  | 
**Policy** | [**List&lt;ProfilePolicy&gt;**](ProfilePolicy.md) | The list of policies comprising the profile.  A *ProfilePolicy* stores one or more configuration data values in a *PolicyOption*. The policy option is one of the configuration options from the *ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption* list.  | [optional] 
**ProfileTypeName** | **string** | Identifies the profile type.  | [optional] 
**ProfileVersion** | **string** | Profile engine version.  | [optional] 
**Property** | [**List&lt;ProfileApplyProfileProperty&gt;**](ProfileApplyProfileProperty.md) | List of subprofiles for this profile.  This list can change depending on which profile plug-ins are available in the system. Subprofiles can be nested to arbitrary depths to represent host capabilities.  | [optional] 
**Favorite** | **bool** | Indicates whether this profile is marked as \&quot;favorite\&quot;.  | [optional] 
**ToBeMerged** | **bool** | Indicates whether this profile is marked as to-be-merged.  | [optional] 
**ToReplaceWith** | **bool** | Indicates whether the selected array elements, with the current as one of them, replace the profile array in the target host profile.  | [optional] 
**ToBeDeleted** | **bool** | Indicates whether this profile is marked as to-be-deleted.  | [optional] 
**CopyEnableStatus** | **bool** | Indicates that the member variable &lt;code&gt;enabled&lt;/code&gt; of this profile will be copied from source profile to target profiles at host profile composition.  | [optional] 
**Hidden** | **bool** | Indicates whether this profile will be displayed or not.  | [optional] 
**Vswitch** | [**List&lt;VirtualSwitchProfile&gt;**](VirtualSwitchProfile.md) | List of virtual switch subprofiles.  Use the *VirtualSwitchProfile.key* property to access a subprofile in the list.  | [optional] 
**VmPortGroup** | [**List&lt;VmPortGroupProfile&gt;**](VmPortGroupProfile.md) | List of port groups for use by virtual machines.  Use the *VmPortGroupProfile*.*PortGroupProfile.key* property to access a port group in the list.  | [optional] 
**HostPortGroup** | [**List&lt;HostPortGroupProfile&gt;**](HostPortGroupProfile.md) | List of port groups for use by the host.  Use the *HostPortGroupProfile*.*PortGroupProfile.key* property to access port groups in the list.  | [optional] 
**ServiceConsolePortGroup** | [**List&lt;ServiceConsolePortGroupProfile&gt;**](ServiceConsolePortGroupProfile.md) | List of port groups for use by the service console.  The Profile Engine uses this field only when applying a profile to a host that has a service console.  | [optional] 
**DnsConfig** | [**NetworkProfileDnsConfigProfile**](NetworkProfileDnsConfigProfile.md) | DNS (Domain Name System) configuration subprofile.  | [optional] 
**IpRouteConfig** | [**IpRouteProfile**](IpRouteProfile.md) | Subprofile that describes the IP Route configuration for the VMKernel gateway.  | [optional] 
**ConsoleIpRouteConfig** | [**IpRouteProfile**](IpRouteProfile.md) | Subprofile that describes the IP Route configuration for the Service Console gateway.  | [optional] 
**Pnic** | [**List&lt;PhysicalNicProfile&gt;**](PhysicalNicProfile.md) | List of subprofiles that represent physical NIC configuration.  Use the *PhysicalNicProfile.key* property to access a subprofile in the list.  | [optional] 
**Dvswitch** | [**List&lt;DvsProfile&gt;**](DvsProfile.md) | List of subprofiles for distributed virtual switches to which this host is connected.  Use the *DvsProfile.key* property to access a subprofile in the list.  | [optional] 
**DvsServiceConsoleNic** | [**List&lt;DvsServiceConsoleVNicProfile&gt;**](DvsServiceConsoleVNicProfile.md) | List of subprofiles for service console Virtual NICs connected to a distributed virtual switch.  Use the *DvsServiceConsoleVNicProfile*.*DvsVNicProfile.key* property to access a subprofile in the list.  | [optional] 
**DvsHostNic** | [**List&lt;DvsHostVNicProfile&gt;**](DvsHostVNicProfile.md) | List of subprofiles for host Virtual NICs connected to a distributed virtual switch.  Use the *DvsHostVNicProfile*.*DvsVNicProfile.key* property to access a subprofile in the list.  | [optional] 
**NsxHostNic** | [**List&lt;NsxHostVNicProfile&gt;**](NsxHostVNicProfile.md) | List of subprofiles for host Virtual NICs connected to a NSX logic switch.  Use the *NsxHostVNicProfile*.*NsxHostVNicProfile.key* property to access a subprofile in the list.  | [optional] 
**NetStackInstance** | [**List&lt;NetStackInstanceProfile&gt;**](NetStackInstanceProfile.md) | List of NetStackInstance subprofiles.  Use the *NetStackInstanceProfile.key* property to access a subprofile in the list.  | [optional] 
**OpaqueSwitch** | [**OpaqueSwitchProfile**](OpaqueSwitchProfile.md) | OpaqueSwitch subprofile.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

