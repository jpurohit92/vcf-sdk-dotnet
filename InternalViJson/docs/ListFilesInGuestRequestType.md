# Vcenter.ViJson.OpenApi.Model.ListFilesInGuestRequestType
The parameters of *GuestFileManager.ListFilesInGuest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine to perform the operation on.  ***Required privileges:*** VirtualMachine.GuestOperations.Query  Refers instance of *VirtualMachine*.  | 
**Auth** | [**GuestAuthentication**](GuestAuthentication.md) | The guest authentication data. See *GuestAuthentication*.  | 
**FilePath** | **string** | The complete path to the directory or file to query.  | 
**Index** | **int** | Which result to start the list with. The default is 0.  | [optional] 
**MaxResults** | **int** | The maximum number of results to return. The default is 50.  | [optional] 
**MatchPattern** | **string** | A filter for the return values. Match patterns are specified using perl-compatible regular expressions. If matchPattern is unset, then the pattern &#39;.\\*&#39; is used.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

