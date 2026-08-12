# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareCdromCreateSpec
The Vcenter.Vm.Hardware.Cdrom.CreateSpec schema provides a specification for the configuration of a newly-created virtual CD-ROM device.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of host bus adapter to which the device should be attached.  Possible values:   - &#x60;IDE&#x60;: Cdrom is attached to an IDE adapter.   - &#x60;SATA&#x60;: Cdrom is attached to a SATA adapter.   For more information see: *Vcenter.Vm.Hardware.Cdrom.HostBusAdapterType*.  If missing or &#x60;null&#x60;, guest-specific default values will be used | [optional] 
**Ide** | [**VcenterVmHardwareIdeAddressSpec**](VcenterVmHardwareIdeAddressSpec.md) | Address for attaching the device to a virtual IDE adapter.  If missing or &#x60;null&#x60;, the server will choose an available address; if none is available, the request will fail. | [optional] 
**Sata** | [**VcenterVmHardwareSataAddressSpec**](VcenterVmHardwareSataAddressSpec.md) | Address for attaching the device to a virtual SATA adapter.  If missing or &#x60;null&#x60;, the server will choose an available address; if none is available, the request will fail. | [optional] 
**Backing** | [**VcenterVmHardwareCdromBackingSpec**](VcenterVmHardwareCdromBackingSpec.md) | Physical resource backing for the virtual CD-ROM device.  If missing or &#x60;null&#x60;, defaults to automatic detection of a suitable host device. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

