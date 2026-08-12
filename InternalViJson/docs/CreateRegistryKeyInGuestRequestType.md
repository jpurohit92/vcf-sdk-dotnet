# Vcenter.ViJson.OpenApi.Model.CreateRegistryKeyInGuestRequestType
The parameters of *GuestWindowsRegistryManager.CreateRegistryKeyInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**KeyName** | [**GuestRegKeyNameSpec**](GuestRegKeyNameSpec.md) | The path to the registry key to be created.  | 
**IsVolatile** | **bool** | If true, the key is created in memory and is not preserved across system reboot. Otherwise, it shall persist in the file system.  | 
**ClassType** | **string** | User defined class type for this key. May be omitted.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

