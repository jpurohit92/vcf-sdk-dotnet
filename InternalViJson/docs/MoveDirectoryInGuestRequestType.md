# Vcenter.ViJson.OpenApi.Model.MoveDirectoryInGuestRequestType
The parameters of *GuestFileManager.MoveDirectoryInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**SrcDirectoryPath** | **string** | The complete path to the directory to be moved.  | 
**DstDirectoryPath** | **string** | The complete path to the where the directory is moved or its new name. It cannot be a path to an existing directory or an existing file.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

