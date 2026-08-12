# Vcenter.ViJson.OpenApi.Model.InitiateFileTransferToGuestRequestType
The parameters of *GuestFileManager.InitiateFileTransferToGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**GuestFilePath** | **string** | The complete destination path in the guest to transfer the file from the client. It cannot be a path to a directory or a symbolic link.  | 
**FileAttributes** | [**GuestFileAttributes**](GuestFileAttributes.md) | File attributes of the file that has to be created in the guest. See *GuestFileAttributes*. If any file attribute is not specified, then the default value of that property will be set for the file.  | 
**FileSize** | **long** | Size of the file to transfer to the guest in bytes.  | 
**Overwrite** | **bool** | If set, the destination file is clobbered.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

