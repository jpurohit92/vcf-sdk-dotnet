# Vcenter.ViJson.OpenApi.Model.QueryDirectoryInfoRequestType
The parameters of *DatastoreNamespaceManager.QueryDirectoryInfo*.  ***Since:*** vSphere API Release 8.0.1.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | the datacenter of the namespace path. Needs to be set when making the call to VC; ignored when the call is made to ESX.  Refers instance of *Datacenter*.  | [optional] 
**StableName** | **string** | stable vmfs path of the top-level directory to query  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

