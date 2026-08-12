# Vcenter.ViJson.OpenApi.Model.DeleteDirectoryInGuestRequestType
The parameters of *GuestFileManager.DeleteDirectoryInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**DirectoryPath** | **string** | The complete path to the directory to be deleted.  | 
**Recursive** | **bool** | If true, all subdirectories are also deleted. If false, the directory must be empty for the operation to succeed.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

