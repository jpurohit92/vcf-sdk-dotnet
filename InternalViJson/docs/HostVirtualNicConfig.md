# Vcenter.ViJson.OpenApi.Model.HostVirtualNicConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeOperation** | **string** | Change operation to apply on this configuration specification.  See also *HostConfigChangeOperation_enum*.  | [optional] 
**Device** | **string** | Virtual NIC device (*HostVirtualNic.device*) to which configuration applies.  | [optional] 
**Portgroup** | **string** | If the Virtual NIC is connecting to a vSwitch, this property is the name of portgroup connected.  If the Virtual NIC is connecting to a *DistributedVirtualSwitch* or *HostOpaqueNetworkInfo*, this property is ignored.  | 
**Spec** | [**HostVirtualNicSpec**](HostVirtualNicSpec.md) | Specification of the virtual network adapter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

