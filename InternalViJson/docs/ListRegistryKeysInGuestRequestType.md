# Vcenter.ViJson.OpenApi.Model.ListRegistryKeysInGuestRequestType
The parameters of *GuestWindowsRegistryManager.ListRegistryKeysInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Query  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**KeyName** | [**GuestRegKeyNameSpec**](GuestRegKeyNameSpec.md) | The path to the registry key for which all subkeys are to be listed.  | 
**Recursive** | **bool** | If true, all subkeys are listed recursively.  | 
**MatchPattern** | **string** | A filter for the key names returned, specified using perl-compatible regular expressions. If matchPattern is unset, then the pattern &#39;.\\*&#39; is used, which returns all key names found, otherwise only those key names that match the input pattern shall be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

