# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCustomizationCheckInfo
The Vcenter.Vm.Guest.Customization.CheckInfo schema contains the status of a customization check operation applied to a virtual machine.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckStatus** | **string** | The status of the customization check operation.  Possible values:   - &#x60;SUPPORTED&#x60;: Applying customization operation on a virtual machine is supported, a virtual machine is customizable.   - &#x60;NOT_SUPPORTED&#x60;: Applying customization operation on a virtual machine is not supported, a virtual machine is not customizable.   For more information see: *Vcenter.Vm.Guest.Customization.CheckInfo.CheckStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**SupportedGuestOs** | **bool** | Whether or not the guest OS is supported by customization operation. If supported_guest_os is false in the status of a customization check operation, the virtual machine is not customizable due to the guest OS is not supported by customization operation.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the customization check operation has not reached the step of checking guest OS. | [optional] 
**SupportedPowerState** | **bool** | Whether or not customization operation is supported in the current power state. If supported_power_state is false in the status of a customization check operation, the virtual machine is not customizable due to customization operation is not supported in the current power state.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the customization check operation has not reached the step of checking power state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

