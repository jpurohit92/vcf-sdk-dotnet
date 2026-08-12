# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareMemoryUpdateSpec
The Vcenter.Vm.Hardware.Memory.UpdateSpec schema describes the updates to be made to the memory-related settings of a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SizeMib** | **long** | New memory size in mebibytes.    The supported range of memory sizes is constrained by the configured guest operating system and virtual hardware version of the virtual machine.    If the virtual machine is running, this value may only be changed if *Vcenter.Vm.Hardware.Memory.Info.hot_add_enabled* is true, and the new memory size must satisfy the constraints specified by *Vcenter.Vm.Hardware.Memory.Info.hot_add_increment_size_MiB* and *Vcenter.Vm.Hardware.Memory.Info.hot_add_limit_MiB*.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**HotAddEnabled** | **bool** | Flag indicating whether adding memory while the virtual machine is running should be enabled.    Some guest operating systems may consume more resources or perform less efficiently when they run on hardware that supports adding memory while the machine is running.    This property may only be modified if the virtual machine is not powered on.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

