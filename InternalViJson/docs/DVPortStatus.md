# Vcenter.ViJson.OpenApi.Model.DVPortStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkUp** | **bool** | Indicates whether the port is in linkUp status.  | 
**Blocked** | **bool** | Indicates whether the port is blocked by switch implementation.  | 
**VlanIds** | [**List&lt;NumericRange&gt;**](NumericRange.md) | VLAN ID of the port.  | [optional] 
**TrunkingMode** | **bool** | True if the port VLAN tagging/stripping is disabled.  | [optional] 
**Mtu** | **int** | Maximum transmission unit (MTU) of the port.  You can set the MTU only at the switch level (*VMwareDVSConfigSpec*). If you attempt to change it at the portgroup or port level, the Server throws an exception.  | [optional] 
**LinkPeer** | **string** | Name of the connected entity.  | [optional] 
**MacAddress** | **string** | The MAC address that is used at this port.  | [optional] 
**StatusDetail** | **string** | Additional information regarding the current status of the port.  | [optional] 
**VmDirectPathGen2Active** | **bool** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Indicates whether VMDirectPath Gen 2 is active on this port.  If false, the reason(s) for inactivity will be provided in one or more of *DVPortStatus.vmDirectPathGen2InactiveReasonNetwork*, *DVPortStatus.vmDirectPathGen2InactiveReasonOther*, and *DVPortStatus.vmDirectPathGen2InactiveReasonExtended*.  If the host software is not capable of VMDirectPath Gen 2, this property will be unset. See *HostCapability*.*HostCapability.vmDirectPathGen2Supported*.  | [optional] 
**VmDirectPathGen2InactiveReasonNetwork** | **List&lt;string&gt;** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  If *DVPortStatus.vmDirectPathGen2Active* is false, this array will be populated with reasons for the inactivity that are related to network state or configuration.  The reasons are chosen from the *DVPortStatusVmDirectPathGen2InactiveReasonNetwork_enum* values.  Other reasons for inactivity will be provided in *DVPortStatus.vmDirectPathGen2InactiveReasonOther*. If there is a reason for inactivity that cannot be described by the available constants, *DVPortStatus.vmDirectPathGen2InactiveReasonExtended* will be populated with an additional explanation provided by the platform.  Note that this list of reasons is not guaranteed to be exhaustive.  | [optional] 
**VmDirectPathGen2InactiveReasonOther** | **List&lt;string&gt;** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  If *DVPortStatus.vmDirectPathGen2Active* is false, this array will be populated with reasons for the inactivity that are not related to network state or configuration.  The reasons are chosen from the *DVPortStatusVmDirectPathGen2InactiveReasonOther_enum* values.  Network-related reasons for inactivity will be provided in *DVPortStatus.vmDirectPathGen2InactiveReasonNetwork*. If there is a reason for inactivity that cannot be described by the available constants, *DVPortStatus.vmDirectPathGen2InactiveReasonExtended* will be populated with an additional explanation provided by the platform.  Note that this list of reasons is not guaranteed to be exhaustive.  See also *HostCapability.vmDirectPathGen2Supported*.  | [optional] 
**VmDirectPathGen2InactiveReasonExtended** | **string** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  If *DVPortStatus.vmDirectPathGen2Active* is false, this property may contain an explanation provided by the platform, beyond the reasons (if any) listed in *DVPortStatus.vmDirectPathGen2InactiveReasonNetwork* and/or *DVPortStatus.vmDirectPathGen2InactiveReasonOther*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

