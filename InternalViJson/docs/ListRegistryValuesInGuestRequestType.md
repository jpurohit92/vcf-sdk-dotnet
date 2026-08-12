# Vcenter.ViJson.OpenApi.Model.ListRegistryValuesInGuestRequestType
The parameters of *GuestWindowsRegistryManager.ListRegistryValuesInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Query  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data.  | 
**KeyName** | [**GuestRegKeyNameSpec**](GuestRegKeyNameSpec.md) | The path to the registry key for which all values are to be listed.  | 
**ExpandStrings** | **bool** | If true, all values that have expandable data such as environment variable names, shall get expanded in the result.  | 
**MatchPattern** | **string** | A filter for the value names returned, specified using perl-compatible regular expressions. If matchPattern is unset, then the pattern &#39;.\\*&#39; is used, which returns all value names found, otherwise only those value names that match the input pattern shall be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

