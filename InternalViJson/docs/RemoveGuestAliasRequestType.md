# Vcenter.ViJson.OpenApi.Model.RemoveGuestAliasRequestType
The parameters of *GuestAliasManager.RemoveGuestAlias*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.ModifyAliases  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data for this operation. See *GuestAuthentication*. These credentials must satisfy authentication requirements for a guest account on the specified virtual machine.  | 
**Username** | **string** | Username for the guest account on the virtual machine.  | 
**Base64Cert** | **string** | The X.509 certificate associated with the alias to be removed, in base64 encoded DER format.  | 
**Subject** | [**GuestAuthSubject**](GuestAuthSubject.md) | The subject of the alias.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

