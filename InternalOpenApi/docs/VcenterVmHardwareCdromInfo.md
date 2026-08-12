# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareCdromInfo
The Vcenter.Vm.Hardware.Cdrom.Info schema contains information about a virtual CD-ROM device.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of host bus adapter to which the device is attached.  Possible values:   - &#x60;IDE&#x60;: Cdrom is attached to an IDE adapter.   - &#x60;SATA&#x60;: Cdrom is attached to a SATA adapter.   For more information see: *Vcenter.Vm.Hardware.Cdrom.HostBusAdapterType*. | 
**Label** | **string** | Device label. | 
**Ide** | [**VcenterVmHardwareIdeAddressInfo**](VcenterVmHardwareIdeAddressInfo.md) | Address of device attached to a virtual IDE adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Cdrom.HostBusAdapterType.IDE*. | [optional] 
**Sata** | [**VcenterVmHardwareSataAddressInfo**](VcenterVmHardwareSataAddressInfo.md) | Address of device attached to a virtual SATA adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Cdrom.HostBusAdapterType.SATA*. | [optional] 
**Backing** | [**VcenterVmHardwareCdromBackingInfo**](VcenterVmHardwareCdromBackingInfo.md) | Physical resource backing for the virtual CD-ROM device. | 
**State** | **string** | Connection status of the virtual device.  Possible values:   - &#x60;CONNECTED&#x60;: The device is connected and working correctly.   - &#x60;RECOVERABLE_ERROR&#x60;: Device connection failed due to a recoverable error; for example, the virtual device backing is currently in use by another virtual machine.   - &#x60;UNRECOVERABLE_ERROR&#x60;: Device connection failed due to an unrecoverable error; for example, the virtual device backing does not exist.   - &#x60;NOT_CONNECTED&#x60;: The device is not connected.   - &#x60;UNKNOWN&#x60;: The device status is unknown.   For more information see: *Vcenter.Vm.Hardware.ConnectionState*. | 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on. | 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

