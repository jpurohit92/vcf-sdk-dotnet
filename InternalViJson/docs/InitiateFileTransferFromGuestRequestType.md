# Vcenter.ViJson.OpenApi.Model.InitiateFileTransferFromGuestRequestType
The parameters of *GuestFileManager.InitiateFileTransferFromGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Query  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**GuestFilePath** | **string** | The complete path to the file inside the guest that has to be transferred to the client. It cannot be a path to a directory or a symbolic link.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

