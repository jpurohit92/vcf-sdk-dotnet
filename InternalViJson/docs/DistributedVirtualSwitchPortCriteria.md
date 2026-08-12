# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchPortCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**Connected** | **bool** | If set, only the connected ports are qualified.  | [optional] 
**Active** | **bool** | If set, only the active ports are qualified.  | [optional] 
**UplinkPort** | **bool** | If set to true, only the uplink ports are qualified.  If set to false, only non-uplink ports are qualified.  | [optional] 
**NsxPort** | **bool** | If set to true, only the NSX ports are qualified.  If set to false, only non-NSX ports are qualified. NSX ports are ports of NSX port group.  | [optional] 
**Scope** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated as of vSphere API 5.5.  If set, only the ports of which the scope covers the entity are qualified.  Refers instance of *ManagedEntity*.  | [optional] 
**PortgroupKey** | **List&lt;string&gt;** | The keys of the portgroup that is used for the scope of *DistributedVirtualSwitchPortCriteria.inside*.  If this property is unset, it means any portgroup. If *DistributedVirtualSwitchPortCriteria.inside* is unset, this property is ignored.  | [optional] 
**Inside** | **bool** | If unset, all ports in the switch are qualified.  If set to true, only ports inside *DistributedVirtualSwitchPortCriteria.portgroupKey* or any portgroup, if not set, are qualified. If set to false, only ports outside *DistributedVirtualSwitchPortCriteria.portgroupKey* or any portgroup, if not set, are qualified.  | [optional] 
**PortKey** | **List&lt;string&gt;** | If set, only the ports of which the key is in the array are qualified.  | [optional] 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If set, only the ports that are present in one of the host are qualified.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

