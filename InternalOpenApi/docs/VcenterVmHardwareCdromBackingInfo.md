# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareCdromBackingInfo
The Vcenter.Vm.Hardware.Cdrom.BackingInfo schema contains information about the physical resource backing a virtual CD-ROM device.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Backing type for the virtual CD-ROM device.  Possible values:   - &#x60;ISO_FILE&#x60;: Virtual CD-ROM device is backed by an ISO file.   - &#x60;HOST_DEVICE&#x60;: Virtual CD-ROM device is backed by a device on the host where the virtual machine is running.   - &#x60;CLIENT_DEVICE&#x60;: Virtual CD-ROM device is backed by a device on the client that is connected to the virtual machine console.   For more information see: *Vcenter.Vm.Hardware.Cdrom.BackingType*. | 
**IsoFile** | **string** | Path of the image file backing the virtual CD-ROM device.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Cdrom.BackingType.ISO_FILE*. | [optional] 
**HostDevice** | **string** | Name of the host device backing the virtual CD-ROM device.     This property will be missing or &#x60;null&#x60; if auto_detect is true and the virtual CD-ROM device is not connected or no suitable device is available on the host. | [optional] 
**AutoDetect** | **bool** | Flag indicating whether the virtual CD-ROM device is configured to automatically detect a suitable host device.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Cdrom.BackingType.HOST_DEVICE*. | [optional] 
**DeviceAccessType** | **string** | Access type for the device backing.  Possible values:   - &#x60;EMULATION&#x60;: ATAPI or SCSI device emulation.   - &#x60;PASSTHRU&#x60;: Raw passthru device access.   - &#x60;PASSTHRU_EXCLUSIVE&#x60;: Raw passthru device access, with exclusive access to the device.   For more information see: *Vcenter.Vm.Hardware.Cdrom.DeviceAccessType*.  This property is optional and it is only relevant when the value of type is one of *Vcenter.Vm.Hardware.Cdrom.BackingType.HOST_DEVICE* or *Vcenter.Vm.Hardware.Cdrom.BackingType.CLIENT_DEVICE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

