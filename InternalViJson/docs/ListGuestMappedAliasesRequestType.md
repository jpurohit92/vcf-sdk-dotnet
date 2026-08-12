# Vcenter.ViJson.OpenApi.Model.ListGuestMappedAliasesRequestType
The parameters of *GuestAliasManager.ListGuestMappedAliases*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.QueryAliases  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data for this operation. See *GuestAuthentication*. These credentials must satisfy authentication requirements for a guest account on the specified virtual machine.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

