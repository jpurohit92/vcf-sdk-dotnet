# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCustomizationInfo
The Vcenter.Vm.Guest.Customization.Info schema contains the status of a customization operation applied to a virtual machine.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the customization operation.  Possible values:   - &#x60;IDLE&#x60;: No customization spec is applied to the guest operating system.  This constant was added in __vSphere API 7.0.3.0__.   - &#x60;PENDING&#x60;: The customization process has not yet started inside the guest operating system.   - &#x60;RUNNING&#x60;: The customization process is currently running inside the guest operating system.   - &#x60;SUCCEEDED&#x60;: The customization process has completed successfully inside the guest operating system.   - &#x60;FAILED&#x60;: The customizatio process has failed inside the guest operating system.   For more information see: *Vcenter.Vm.Guest.Customization.Info.Status*.  This property was added in __vSphere API 7.0.0.0__. | 
**Error** | **string** | Description of the error if the *Vcenter.Vm.Guest.Customization.Info.status* of customization operation is *Vcenter.Vm.Guest.Customization.Info.Status.FAILED*.  This property was added in __vSphere API 7.0.0.0__.  This property will be missing or &#x60;null&#x60; if the status is not FAILED or there is no information available for the error. | [optional] 
**StartTime** | **DateTime** | Time when the customization process has started inside the guest operating system.  This property was added in __vSphere API 7.0.0.0__.  This property will be missing or &#x60;null&#x60; if the status is PENDING. | [optional] 
**EndTime** | **DateTime** | Time when the customization process has completed inside the guest operating system.  This property was added in __vSphere API 7.0.0.0__.  This property will be missing or &#x60;null&#x60; if the status is not SUCCEEDED or FAILED. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

