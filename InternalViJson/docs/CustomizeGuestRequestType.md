# Vcenter.ViJson.OpenApi.Model.CustomizeGuestRequestType
The parameters of *VirtualMachineGuestCustomizationManager.CustomizeGuest_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Virtual Machine managed object reference.  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**Spec** | [**CustomizationSpec**](CustomizationSpec.md) | Is a *CustomizationSpec*. It specifies the virtual machine&#39;s configuration.  | 
**ConfigParams** | [**List&lt;OptionValue&gt;**](OptionValue.md) | additional key/value pair list to support third party customization.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

