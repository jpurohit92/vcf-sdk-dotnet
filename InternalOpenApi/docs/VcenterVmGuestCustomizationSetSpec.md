# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCustomizationSetSpec
The Vcenter.Vm.Guest.Customization.SetSpec schema contains specification information that has to be applied to a virtual machine.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the customization specification that has be retrieved from the virtual center inventory and applied for the virtual machine. Either one of name or spec or none of them should be specified.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; and spec is also missing or &#x60;null&#x60; when executing *PUT /vcenter/vm/{vm}/guest/customization* operation, then any pending customization for the virtual machine will be cleared. | [optional] 
**Spec** | [**VcenterGuestCustomizationSpec**](VcenterGuestCustomizationSpec.md) | The customization specification that has to be applied for the virtual machine. Either one of name or spec or none of them should be specified.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; and name is also missing or &#x60;null&#x60; when executing *PUT /vcenter/vm/{vm}/guest/customization* operation, then any pending customization for the virtual machine will be cleared. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

