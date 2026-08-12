# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareCpuUpdateSpec
The Vcenter.Vm.Hardware.Cpu.UpdateSpec schema describes the updates to be made to the CPU-related settings of a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **long** | New number of CPU cores. The number of CPU cores in the virtual machine must be a multiple of the number of cores per socket.    The supported range of CPU counts is constrained by the configured guest operating system and virtual hardware version of the virtual machine.    If the virtual machine is running, the number of CPU cores may only be increased if *Vcenter.Vm.Hardware.Cpu.Info.hot_add_enabled* is true, and may only be decreased if *Vcenter.Vm.Hardware.Cpu.Info.hot_remove_enabled* is true.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**CoresPerSocket** | **long** | New number of CPU cores per socket. The number of CPU cores in the virtual machine must be a multiple of the number of cores per socket.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**HotAddEnabled** | **bool** | Flag indicating whether adding CPUs while the virtual machine is running is enabled.    This property may only be modified if the virtual machine is powered off.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**HotRemoveEnabled** | **bool** | Flag indicating whether removing CPUs while the virtual machine is running is enabled.    This property may only be modified if the virtual machine is powered off.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

