# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareParallelBackingInfo
The Vcenter.Vm.Hardware.Parallel.BackingInfo schema contains information about the physical resource backing a virtual parallel port.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Backing type for the virtual parallel port.  Possible values:   - &#x60;FILE&#x60;: Virtual parallel port is backed by a file.   - &#x60;HOST_DEVICE&#x60;: Virtual parallel port is backed by a device on the host where the virtual machine is running.   For more information see: *Vcenter.Vm.Hardware.Parallel.BackingType*. | 
**File** | **string** | Path of the file backing the virtual parallel port.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Parallel.BackingType.FILE*. | [optional] 
**HostDevice** | **string** | Name of the device backing the virtual parallel port.     This property will be missing or &#x60;null&#x60; if auto_detect is true and the virtual parallel port is not connected or no suitable device is available on the host. | [optional] 
**AutoDetect** | **bool** | Flag indicating whether the virtual parallel port is configured to automatically detect a suitable host device.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Parallel.BackingType.HOST_DEVICE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

