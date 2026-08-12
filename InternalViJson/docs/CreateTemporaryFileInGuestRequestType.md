# Vcenter.ViJson.OpenApi.Model.CreateTemporaryFileInGuestRequestType
The parameters of *GuestFileManager.CreateTemporaryFileInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**Prefix** | **string** | The prefix to be given to the new temporary file.  | 
**Suffix** | **string** | The suffix to be given to the new temporary file.  | 
**DirectoryPath** | **string** | The complete path to the directory in which to create the file. If unset, or an empty string, a guest-specific location will be used.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

