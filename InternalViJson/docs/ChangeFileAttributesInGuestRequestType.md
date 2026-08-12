# Vcenter.ViJson.OpenApi.Model.ChangeFileAttributesInGuestRequestType
The parameters of *GuestFileManager.ChangeFileAttributesInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**GuestFilePath** | **string** | The complete path to the file to be copied in the guest. If the file points to an symbolic link, then the attributes of the target file are changed.  | 
**FileAttributes** | [**GuestFileAttributes**](GuestFileAttributes.md) | Specifies the different file attributes of the guest file to be changed. See *GuestFileAttributes*. If any property is not specified, then the specific attribute of the file will be unchanged.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

