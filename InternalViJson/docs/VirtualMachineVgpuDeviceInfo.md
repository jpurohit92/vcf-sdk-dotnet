# Vcenter.ViJson.OpenApi.Model.VirtualMachineVgpuDeviceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**DeviceName** | **string** | The vGPU device name.  | 
**DeviceVendorId** | **long** | A well-known unique identifier for the device.  It concatenates the 16-bit PCI vendor id in lower bits followed by 16-bit PCI device id.  | 
**MaxFbSizeInGib** | **long** | The maximum framebuffer size in gibibytes.  | 
**TimeSlicedCapable** | **bool** | Indicate whether device is time-sliced capable.  | 
**MigCapable** | **bool** | Indicate whether device is Multiple Instance GPU capable.  | 
**ComputeProfileCapable** | **bool** | Indicate whether device is compute profile capable.  | 
**QuadroProfileCapable** | **bool** | Indicate whether device is quadro profile capable.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

