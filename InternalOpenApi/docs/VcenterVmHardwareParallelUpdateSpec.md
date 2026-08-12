# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareParallelUpdateSpec
The Vcenter.Vm.Hardware.Parallel.UpdateSpec schema describes the updates to be made to the configuration of a virtual parallel port.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Backing** | [**VcenterVmHardwareParallelBackingSpec**](VcenterVmHardwareParallelBackingSpec.md) | Physical resource backing for the virtual parallel port.    This property may only be modified if the virtual machine is not powered on or the virtual parallel port is not connected.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

