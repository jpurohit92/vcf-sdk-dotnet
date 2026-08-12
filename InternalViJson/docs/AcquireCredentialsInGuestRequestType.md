# Vcenter.ViJson.OpenApi.Model.AcquireCredentialsInGuestRequestType
The parameters of *GuestAuthManager.AcquireCredentialsInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | MoRef of the VM to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Query  Refers instance of *VirtualMachine*.  | 
**RequestedAuth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data used to acquire credentials. See *GuestAuthentication*.  | 
**SessionID** | **long** | The sessionID number should be provided only when responding to a server challenge. The sessionID number to be used with the challenge is found in the *GuestAuthenticationChallenge* object.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

