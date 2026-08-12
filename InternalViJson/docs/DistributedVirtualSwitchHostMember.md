# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchHostMember

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**RuntimeState** | [**DistributedVirtualSwitchHostMemberRuntimeState**](DistributedVirtualSwitchHostMemberRuntimeState.md) | Host member runtime state.  | [optional] 
**Config** | [**DistributedVirtualSwitchHostMemberConfigInfo**](DistributedVirtualSwitchHostMemberConfigInfo.md) | Host member configuration.  | 
**ProductInfo** | [**DistributedVirtualSwitchProductSpec**](DistributedVirtualSwitchProductSpec.md) | Vendor, product and version information for the proxy switch module.  | [optional] 
**UplinkPortKey** | **List&lt;string&gt;** | Port keys of the uplink ports created for the host member.  These ports will be deleted after the host leaves the switch.  | [optional] 
**Status** | **string** | Deprecated as of vSphere API 5.1, use *HostMemberRuntimeInfo*.*HostMemberRuntimeInfo.status* instead.  The host DistributedVirtualSwitch component status.  See *HostComponentState* for valid values.  | 
**StatusDetail** | **string** | Deprecated as of vSphere API 5.1, use *HostMemberRuntimeInfo*.*HostMemberRuntimeInfo.statusDetail* instead.  Additional information regarding the host&#39;s current status.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

