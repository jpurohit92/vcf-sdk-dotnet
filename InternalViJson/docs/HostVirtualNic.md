# Vcenter.ViJson.OpenApi.Model.HostVirtualNic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | Device name.  | 
**Key** | **string** | Linkable identifier.  | 
**Portgroup** | **string** | If the Virtual NIC is connecting to a vSwitch, this property is the name of portgroup connected.  If the Virtual NIC is connecting to a DistributedVirtualSwitch or opaque network, this property is an empty string.  | 
**Spec** | [**HostVirtualNicSpec**](HostVirtualNicSpec.md) | Configurable properties for the virtual network adapter object.  | 
**Port** | **string** | Port(*HostPortGroup.port*) on the port group that the virtual NIC is using when it is enabled.  If the Virtual NIC is connected to DistributedVirtualSwitch or opaque network, this property is unset.  | [optional] 
**Owner** | **string** | Owner of vmknic.  It is only valid for system vmknic. The unset means not owned by the system. See *HostConfigChangeOwner_enum* for supported values.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

