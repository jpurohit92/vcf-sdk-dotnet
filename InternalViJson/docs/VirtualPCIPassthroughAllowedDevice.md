# Vcenter.ViJson.OpenApi.Model.VirtualPCIPassthroughAllowedDevice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorId** | **int** | The vendor ID for this PCI device.  You must use the vendor ID retrieved from the vSphere host or cluster.  | 
**DeviceId** | **int** | The device ID of this PCI device.  You must use the device ID retrieved from the vSphere host or cluster.  | 
**SubVendorId** | **int** | The subVendor ID for this PCI device.  If specified, you must use the subVendor ID retrieved from the vSphere host or cluster. Range of legal values is 0x0 to 0xFFFF.  | [optional] 
**SubDeviceId** | **int** | The subDevice ID of this PCI device.  If specified, you must use the subDevice ID retrieved from the vSphere host or cluster. Range of legal values is 0x0 to 0xFFFF.  | [optional] 
**RevisionId** | **int** | The revision ID of this PCI device.  If specified, you must use the revision ID retrieved from the vSphere host or cluster. Range of legal values is 0x0 to 0xFF.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

