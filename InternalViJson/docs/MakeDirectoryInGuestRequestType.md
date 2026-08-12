# Vcenter.ViJson.OpenApi.Model.MakeDirectoryInGuestRequestType
The parameters of *GuestFileManager.MakeDirectoryInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**DirectoryPath** | **string** | The complete path to the directory to be created.  | 
**CreateParentDirectories** | **bool** | Whether any parent directories are to be created.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

