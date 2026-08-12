# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCustomizationLiveRunSpec
The Vcenter.Vm.Guest.CustomizationLive.RunSpec schema contains specification information and authentication that have to be applied to a running virtual machine in the *POST /vcenter/vm/{vm}/guest/customization-live?action=run* operation    name or spec only supports to be configured as *Vcenter.Guest.ConfigurationSpec.linux_config*, also the *Vcenter.Guest.LinuxConfiguration.script_text* is not supported yet.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the customization specification that has been retrieved from the virtual center inventory and applied for the virtual machine. Either name or spec should be specified, name and spec can not be missing or &#x60;null&#x60; at the same time. If both name and spec are specified, name will be used by default.  This property was added in __vSphere API 9.0.0.0__.  if spec is missing or &#x60;null&#x60; when executing *POST /vcenter/vm/{vm}/guest/customization-live?action&#x3D;run* operation, then name should be specified.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.guest.CustomizationSpec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.guest.CustomizationSpec&#x60;. | [optional] 
**Spec** | [**VcenterGuestCustomizationSpec**](VcenterGuestCustomizationSpec.md) | The customization specification that has to be applied for the virtual machine. Either name or spec should be specified. name and spec can not be missing or &#x60;null&#x60; at the same time. If name and spec are specified, name will be used by default.  This property was added in __vSphere API 9.0.0.0__.  if name is missing or &#x60;null&#x60; when executing *POST /vcenter/vm/{vm}/guest/customization-live?action&#x3D;run* operation, then spec should be specified. | [optional] 
**Auth** | [**VcenterVmGuestCustomizationLiveGuestAuthentication**](VcenterVmGuestCustomizationLiveGuestAuthentication.md) | The guest authentication data.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

