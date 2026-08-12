# Vcenter.ViJson.OpenApi.Model.HostOpaqueSwitch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**Key** | **string** | The opaque switch ID.  | 
**Name** | **string** | The opaque switch name.  | [optional] 
**Pnic** | **List&lt;string&gt;** | The set of physical network adapters associated with this switch.  | [optional] 
**PnicZone** | [**List&lt;HostOpaqueSwitchPhysicalNicZone&gt;**](HostOpaqueSwitchPhysicalNicZone.md) | The IDs of networking zones associated with this switch.  | [optional] 
**Status** | **string** | Opaque switch status.  See *OpaqueSwitchState* for valid values.  | [optional] 
**Vtep** | [**List&lt;HostVirtualNic&gt;**](HostVirtualNic.md) | List of VTEPs associated with this switch.  | [optional] 
**ExtraConfig** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Extra NSX specific properties for opaque switch.  | [optional] 
**FeatureCapability** | [**List&lt;HostFeatureCapability&gt;**](HostFeatureCapability.md) | Array of host specific feature capabilities that the switch has.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

