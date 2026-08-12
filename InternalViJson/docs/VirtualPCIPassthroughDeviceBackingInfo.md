# Vcenter.ViJson.OpenApi.Model.VirtualPCIPassthroughDeviceBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 
**Id** | **string** | The name ID of this PCI, composed of \&quot;bus:slot.function\&quot;.  | 
**DeviceId** | **string** | The device ID of this PCI.  You must use the device ID retrieved from the vSphere host (*HostPciDevice*.deviceId), converted as is to a string.  | 
**SystemId** | **string** | The ID of the system the PCI device is attached to.  | 
**VendorId** | **int** | The vendor ID for this PCI device.  You must use the vendor ID retrieved from the vSphere host (*HostPciDevice*.vendorId).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

