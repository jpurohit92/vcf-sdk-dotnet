# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareMemoryInfo
The Vcenter.Vm.Hardware.Memory.Info schema contains memory-related information about a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SizeMib** | **long** | Memory size in mebibytes. | 
**HotAddEnabled** | **bool** | Flag indicating whether adding memory while the virtual machine is running is enabled.    Some guest operating systems may consume more resources or perform less efficiently when they run on hardware that supports adding memory while the machine is running. | 
**HotAddIncrementSizeMib** | **long** | Only set when *Vcenter.Vm.Hardware.Memory.Info.hot_add_enabled* is true and the virtual machine is running. | [optional] 
**HotAddLimitMib** | **long** | The maximum amount of memory, in mebibytes, that can be added to a running virtual machine.  Only set when *Vcenter.Vm.Hardware.Memory.Info.hot_add_enabled* is true and the virtual machine is running. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

