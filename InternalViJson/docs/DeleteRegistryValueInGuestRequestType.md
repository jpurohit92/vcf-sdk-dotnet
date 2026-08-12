# Vcenter.ViJson.OpenApi.Model.DeleteRegistryValueInGuestRequestType
The parameters of *GuestWindowsRegistryManager.DeleteRegistryValueInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**ValueName** | [**GuestRegValueNameSpec**](GuestRegValueNameSpec.md) | The registry value name to be deleted. The Value \&quot;name\&quot; (specified in *GuestRegValueNameSpec*) can be empty. If \&quot;name\&quot; is empty, it deletes the value for the unnamed or default value of the given key.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

