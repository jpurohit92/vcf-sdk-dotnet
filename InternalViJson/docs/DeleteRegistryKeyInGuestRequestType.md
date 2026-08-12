# Vcenter.ViJson.OpenApi.Model.DeleteRegistryKeyInGuestRequestType
The parameters of *GuestWindowsRegistryManager.DeleteRegistryKeyInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**KeyName** | [**GuestRegKeyNameSpec**](GuestRegKeyNameSpec.md) | The path to the registry key to be deleted.  | 
**Recursive** | **bool** | If true, the key is deleted along with any subkeys (if present). Otherwise, it shall only delete the key if it has no subkeys.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

