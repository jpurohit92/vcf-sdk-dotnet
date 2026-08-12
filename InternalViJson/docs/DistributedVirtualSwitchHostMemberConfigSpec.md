# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchHostMemberConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**Operation** | **string** | Host member operation type.  See *ConfigSpecOperation_enum* for valid values.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Identifies a host member of a *DistributedVirtualSwitch* for a *Folder.CreateDVS_Task* or *DistributedVirtualSwitch*.*DistributedVirtualSwitch.ReconfigureDvs_Task* operation.  Refers instance of *HostSystem*.  | 
**Backing** | [**DistributedVirtualSwitchHostMemberBacking**](DistributedVirtualSwitchHostMemberBacking.md) | Specifies the physical NICs to use as backing for the proxy switch on the host.  | [optional] 
**MaxProxySwitchPorts** | **int** | Maximum number of ports allowed in the *HostProxySwitch*.  _ESXi 5.0 and earlier hosts_: If you are reconfiguring an existing host membership, that is, the proxy switch already exists, you must reboot the host for the new setting to take effect.  | [optional] 
**VendorSpecificConfig** | [**List&lt;DistributedVirtualSwitchKeyedOpaqueBlob&gt;**](DistributedVirtualSwitchKeyedOpaqueBlob.md) | Opaque binary blob that stores vendor specific configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

