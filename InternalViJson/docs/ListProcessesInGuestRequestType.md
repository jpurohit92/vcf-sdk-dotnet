# Vcenter.ViJson.OpenApi.Model.ListProcessesInGuestRequestType
The parameters of *GuestProcessManager.ListProcessesInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Query  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**Pids** | **List&lt;long&gt;** | If set, only return information about the specified processes. Otherwise, information about all processes are returned. If a specified processes does not exist, nothing will be returned for that process.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

