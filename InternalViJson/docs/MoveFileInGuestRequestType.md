# Vcenter.ViJson.OpenApi.Model.MoveFileInGuestRequestType
The parameters of *GuestFileManager.MoveFileInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Modify  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**SrcFilePath** | **string** | The complete path to the original file or symbolic link to be moved.  | 
**DstFilePath** | **string** | The complete path to the where the file is renamed. It cannot be a path to an existing directory.  | 
**Overwrite** | **bool** | If set, the destination file is clobbered.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

