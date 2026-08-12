# Vcenter.ViJson.OpenApi.Model.IscsiPortInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VnicDevice** | **string** | Virtual NIC Name.  Contains the name of the Virtual NIC device. This may be unset in case where the bound Virtual NIC doesn&#39;t have the system object or where a candidate Physical NIC isn&#39;t associated with any Virtual NIC.  | [optional] 
**Vnic** | [**HostVirtualNic**](HostVirtualNic.md) | Virtual NIC Object corresponding to the vnicDevice.  May be unset if Virtual NIC object corresponding to vnicDevice doesn&#39;t exist in the system.  | [optional] 
**PnicDevice** | **string** | Physical NIC Name.  | [optional] 
**Pnic** | [**PhysicalNic**](PhysicalNic.md) | Physical NIC Object corresponding to the pnicDevice.  May be unset if Physical NIC object corresponding to pnicDevice doesn&#39;t exist in the system or the vnicDevice doesn&#39;t have any Physical NIC associated with it.  | [optional] 
**SwitchName** | **string** | Name of the virtual switch this Physical/Virtual NIC belongs.  May be unset if the vnicDevice and/or pnicDevice do not have a virtual switch associated with them.  | [optional] 
**SwitchUuid** | **string** | UUID of the virtual switch this Physical/Virtual NIC belongs.  May be unset if the vnicDevice and/or pnicDevice do not have a virtual switch associated with them or the associated switch is not VDS.  | [optional] 
**PortgroupName** | **string** | Name of the portgroup to which this Virtual NIC belongs.  May be unset if the vnicDevice and/or pnicDevice do not have a Portgroup associated with them.  | [optional] 
**PortgroupKey** | **string** | Portgroup key to which this Virtual NIC belongs.  May be unset if the vnicDevice and/or pnicDevice do not have a Portgroup associated with them or the associated portgroup does is not of VDS type.  | [optional] 
**PortKey** | **string** | portkey to which this Virtual NIC belongs.  May be unset if the vnicDevice is not assigned to a specific port or the switch is not VDS.  | [optional] 
**OpaqueNetworkId** | **string** | ID of the Opaque network to which the virtual NIC is connected.  This property is set only when vnicDevice is associated with an opaque network.  | [optional] 
**OpaqueNetworkType** | **string** | Type of the Opaque network to which the virtual NIC is connected.  This property is set only when vnicDevice is associated with an opaque network.  | [optional] 
**OpaqueNetworkName** | **string** | Name of the Opaque network to which the virtual NIC is connected.  This property is set only when vnicDevice is associated with an opaque network.  | [optional] 
**ExternalId** | **string** | An ID assigned to the vmkernel adapter by external management plane or controller.  This property is set only when vnicDevice is associated with an opaque network.  | [optional] 
**ComplianceStatus** | [**IscsiStatus**](IscsiStatus.md) | Status indicating whether the Virtual NIC is compliant with the network policy that is required by iSCSI port binding.  May be unset in the candidate NIC list.  | [optional] 
**PathStatus** | **string** | A status, as defined in *IscsiPortInfoPathStatus_enum*, indicating the existing storage paths dependency level on a given Virtual NIC.  May be unset in the candidate NIC list.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

