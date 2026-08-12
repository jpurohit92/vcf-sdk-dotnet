# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareParallelCreateSpec
The Vcenter.Vm.Hardware.Parallel.CreateSpec schema provides a specification for the configuration of a newly-created virtual parallel port.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Backing** | [**VcenterVmHardwareParallelBackingSpec**](VcenterVmHardwareParallelBackingSpec.md) | Physical resource backing for the virtual parallel port.  If missing or &#x60;null&#x60;, defaults to automatic detection of a suitable host device. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

