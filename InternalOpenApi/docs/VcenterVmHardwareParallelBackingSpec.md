# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareParallelBackingSpec
The Vcenter.Vm.Hardware.Parallel.BackingSpec schema provides a specification of the physical resource backing a virtual parallel port.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Backing type for the virtual parallel port.  Possible values:   - &#x60;FILE&#x60;: Virtual parallel port is backed by a file.   - &#x60;HOST_DEVICE&#x60;: Virtual parallel port is backed by a device on the host where the virtual machine is running.   For more information see: *Vcenter.Vm.Hardware.Parallel.BackingType*. | 
**File** | **string** | Path of the file that should be used as the virtual parallel port backing.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Parallel.BackingType.FILE*. | [optional] 
**HostDevice** | **string** | Name of the device that should be used as the virtual parallel port backing.  If missing or &#x60;null&#x60;, the virtual parallel port will be configured to automatically detect a suitable host device. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

