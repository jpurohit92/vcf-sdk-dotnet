# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareBootDeviceEntry
The Vcenter.Vm.Hardware.Boot.Device.Entry schema specifies a bootable virtual device class or specific bootable virtual device(s).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Virtual device type.  Possible values:   - &#x60;CDROM&#x60;: Virtual CD-ROM device.   - &#x60;DISK&#x60;: Virtual disk device.   - &#x60;ETHERNET&#x60;: Virtual Ethernet adapter.   - &#x60;FLOPPY&#x60;: Virtual floppy drive.   For more information see: *Vcenter.Vm.Hardware.Boot.Device.Type*. | 
**Nic** | **string** | Virtual Ethernet device. Ethernet device to use as boot device for this entry.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Boot.Device.Type.ETHERNET*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Ethernet&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Ethernet&#x60;. | [optional] 
**Disks** | **List&lt;string&gt;** | Virtual disk device. List of virtual disks in boot order.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Boot.Device.Type.DISK*.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

