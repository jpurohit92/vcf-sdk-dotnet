# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareBootDeviceEntryCreateSpec
The schema Vcenter.Vm.Hardware.Boot.Device.EntryCreateSpec specifies a list of bootable virtual device classes. When a VM is being created and a list of Vcenter.Vm.Hardware.Boot.Device.EntryCreateSpec is specified, the boot order of the specific device instances are not specified in this schema. The boot order of the specific device instance will be the order in which the Ethernet and Disk devices appear in the nics and disks respectively.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Virtual Boot device type.  Possible values:   - &#x60;CDROM&#x60;: Virtual CD-ROM device.   - &#x60;DISK&#x60;: Virtual disk device.   - &#x60;ETHERNET&#x60;: Virtual Ethernet adapter.   - &#x60;FLOPPY&#x60;: Virtual floppy drive.   For more information see: *Vcenter.Vm.Hardware.Boot.Device.Type*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

