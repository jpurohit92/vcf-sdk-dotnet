# Vcenter.ViJson.OpenApi.Model.VirtualMachineVMCIDeviceFilterSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rank** | **long** | Long value representing filter rank.  This is the rank of this filter. Filters are guaranteed to be processed in ascending rank order, that is, if rank1 &amp;lt; rank2, then rank1 is processed before rank2. The ranks within an array of filters should be unique.  | 
**Action** | **string** | String value from *VirtualMachineVMCIDeviceAction_enum* enum object.  | 
**Protocol** | **string** | String value from *VirtualMachineVMCIDeviceProtocol_enum* enum object  | 
**Direction** | **string** | String value from *VirtualMachineVMCIDeviceDirection_enum* enum object.  | 
**LowerDstPortBoundary** | **long** | Long value representing the lower destination port boundary.  If unset, the lower destination port boundary is default to the lowest port number supported by the given protocol.  To specify a single port, both lowerDstPortBoundary and upperDstPortBoundary shall be set to the same value.  | [optional] 
**UpperDstPortBoundary** | **long** | Long value representing the upper destination port range.  If unset, the upper destination port boundary is default to the highest port number supported by the given protocol.  To specify a single port, both lowerDstPortBoundary and upperDstPortBoundary shall be set to the same value.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

