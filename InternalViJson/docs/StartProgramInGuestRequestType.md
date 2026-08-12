# Vcenter.ViJson.OpenApi.Model.StartProgramInGuestRequestType
The parameters of *GuestProcessManager.StartProgramInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Execute  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**Spec** | [**GuestProgramSpec**](GuestProgramSpec.md) | The arguments describing the program to be started.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

