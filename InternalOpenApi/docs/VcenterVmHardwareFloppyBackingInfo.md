# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareFloppyBackingInfo
The Vcenter.Vm.Hardware.Floppy.BackingInfo schema contains information about the physical resource backing a virtual floppy drive.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Backing type for the virtual floppy drive.  Possible values:   - &#x60;IMAGE_FILE&#x60;: Virtual floppy drive is backed by an image file.   - &#x60;HOST_DEVICE&#x60;: Virtual floppy drive is backed by a device on the host where the virtual machine is running.   - &#x60;CLIENT_DEVICE&#x60;: Virtual floppy drive is backed by a device on the client that is connected to the virtual machine console.   For more information see: *Vcenter.Vm.Hardware.Floppy.BackingType*. | 
**ImageFile** | **string** | Path of the image file backing the virtual floppy drive.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Floppy.BackingType.IMAGE_FILE*. | [optional] 
**HostDevice** | **string** | Name of the host device backing the virtual floppy drive.     This property will be missing or &#x60;null&#x60; if auto_detect is true and the virtual floppy drive is not connected or no suitable device is available on the host. | [optional] 
**AutoDetect** | **bool** | Flag indicating whether the virtual floppy drive is configured to automatically detect a suitable host device.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Floppy.BackingType.HOST_DEVICE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

