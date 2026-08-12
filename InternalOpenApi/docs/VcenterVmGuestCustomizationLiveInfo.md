# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCustomizationLiveInfo
The Vcenter.Vm.Guest.CustomizationLive.Info schema contains the status of a customization operation applied to a virtual machine.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the customization operation.  Possible values:   - &#x60;NOT_AVAILABLE&#x60;: No customization spec has ever been applied to the guest operating system.   - &#x60;RUNNING&#x60;: The customization process is currently running inside the guest operating system.   - &#x60;SUCCEEDED&#x60;: The customization process has completed successfully inside the guest operating system.   - &#x60;FAILED&#x60;: The customization process has failed inside the guest operating system.   For more information see: *Vcenter.Vm.Guest.CustomizationLive.Info.Status*.  This property was added in __vSphere API 9.0.0.0__. | 
**Error** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of the error if the *Vcenter.Vm.Guest.CustomizationLive.Info.status* of customization operation is *Vcenter.Vm.Guest.CustomizationLive.Info.Status.FAILED*.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the status is not FAILED or there is no information available for the error. | [optional] 
**StartTime** | **DateTime** | Time when the customization process has started inside the guest operating system.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the status is NOT_AVAILABLE . | [optional] 
**EndTime** | **DateTime** | Time when the customization process has completed inside the guest operating system.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the status is not SUCCEEDED or FAILED. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

