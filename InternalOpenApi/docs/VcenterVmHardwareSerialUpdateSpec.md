# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareSerialUpdateSpec
The Vcenter.Vm.Hardware.Serial.UpdateSpec schema describes the updates to be made to the configuration of a virtual serial port.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**YieldOnPoll** | **bool** | CPU yield behavior. If set to true, the virtual machine will periodically relinquish the processor if its sole task is polling the virtual serial port. The amount of time it takes to regain the processor will depend on the degree of other virtual machine activity on the host.    This property may be modified at any time, and changes applied to a connected virtual serial port take effect immediately.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**Backing** | [**VcenterVmHardwareSerialBackingSpec**](VcenterVmHardwareSerialBackingSpec.md) | Physical resource backing for the virtual serial port.    This property may only be modified if the virtual machine is not powered on or the virtual serial port is not connected.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

