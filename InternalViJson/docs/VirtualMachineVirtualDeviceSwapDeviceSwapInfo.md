# Vcenter.ViJson.OpenApi.Model.VirtualMachineVirtualDeviceSwapDeviceSwapInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Is the swap operation enabled for this virtual machine.  | [optional] 
**Applicable** | **bool** | Is the swap operation applicable to this virtual machine? Operation is applicable if it is enabled for the virtual machine, for the host or cluster in which virtual machine resides, operating system supports device swap, and virtual machine has controllers that need to be replaced.  This field is read-only and cannot be modified.  | [optional] 
**Status** | **string** | Status of the operation.  One of *VirtualMachineVirtualDeviceSwapDeviceSwapStatus_enum* This field is read-only and cannot be modified.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

