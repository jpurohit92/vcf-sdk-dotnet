# Vcenter.ViJson.OpenApi.Model.SetRegistryValueInGuestRequestType
The parameters of *GuestWindowsRegistryManager.SetRegistryValueInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**Value** | [**GuestRegValueSpec**](GuestRegValueSpec.md) | The information for the registry value to be set/created. The Value \&quot;name\&quot; (specified in *GuestRegValueNameSpec*) and the Value \&quot;data\&quot; (specified in *GuestRegValueSpec*) can both be empty. If \&quot;name\&quot; is empty, it sets the value for the unnamed or default value of the given key.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

