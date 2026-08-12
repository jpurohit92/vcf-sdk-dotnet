# Vcenter.Automation.OpenApi.Model.VcenterVmPowerInfo
The Vcenter.Vm.Power.Info schema contains information about the power state of a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | Power state of the virtual machine.  Possible values:   - &#x60;POWERED_OFF&#x60;: The virtual machine is powered off.   - &#x60;POWERED_ON&#x60;: The virtual machine is powered on.   - &#x60;SUSPENDED&#x60;: The virtual machine is suspended.   For more information see: *Vcenter.Vm.Power.State*. | 
**CleanPowerOff** | **bool** | Flag indicating whether the virtual machine was powered off cleanly. This property may be used to detect that the virtual machine crashed unexpectedly and should be restarted.  This property is optional and it is only relevant when the value of state is *Vcenter.Vm.Power.State.POWERED_OFF*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

