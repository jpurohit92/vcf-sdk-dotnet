# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareSerialCreateSpec
The Vcenter.Vm.Hardware.Serial.CreateSpec schema provides a specification for the configuration of a newly-created virtual serial port.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**YieldOnPoll** | **bool** | CPU yield behavior. If set to true, the virtual machine will periodically relinquish the processor if its sole task is polling the virtual serial port. The amount of time it takes to regain the processor will depend on the degree of other virtual machine activity on the host.  If missing or &#x60;null&#x60;, defaults to false. | [optional] 
**Backing** | [**VcenterVmHardwareSerialBackingSpec**](VcenterVmHardwareSerialBackingSpec.md) | Physical resource backing for the virtual serial port.  If missing or &#x60;null&#x60;, defaults to automatic detection of a suitable host device. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

