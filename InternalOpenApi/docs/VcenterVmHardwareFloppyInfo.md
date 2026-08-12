# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareFloppyInfo
The Vcenter.Vm.Hardware.Floppy.Info schema contains information about a virtual floppy drive.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Device label. | 
**Backing** | [**VcenterVmHardwareFloppyBackingInfo**](VcenterVmHardwareFloppyBackingInfo.md) | Physical resource backing for the virtual floppy drive. | 
**State** | **string** | Connection status of the virtual device.  Possible values:   - &#x60;CONNECTED&#x60;: The device is connected and working correctly.   - &#x60;RECOVERABLE_ERROR&#x60;: Device connection failed due to a recoverable error; for example, the virtual device backing is currently in use by another virtual machine.   - &#x60;UNRECOVERABLE_ERROR&#x60;: Device connection failed due to an unrecoverable error; for example, the virtual device backing does not exist.   - &#x60;NOT_CONNECTED&#x60;: The device is not connected.   - &#x60;UNKNOWN&#x60;: The device status is unknown.   For more information see: *Vcenter.Vm.Hardware.ConnectionState*. | 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on. | 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

