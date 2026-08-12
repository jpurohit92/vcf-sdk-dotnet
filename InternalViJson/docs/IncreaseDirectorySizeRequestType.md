# Vcenter.ViJson.OpenApi.Model.IncreaseDirectorySizeRequestType
The parameters of *DatastoreNamespaceManager.IncreaseDirectorySize*.  ***Since:*** vSphere API Release 8.0.1.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datacenter** | [**ManagedObjectReference**](ManagedObjectReference.md) | the datacenter of the namespace path. Needs to be set when making the call to VC; ignored when the call is made to ESX.  ***Required privileges:*** System.View  Refers instance of *Datacenter*.  | [optional] 
**StableName** | **string** | stable vmfs path of the top-level directory  | 
**Size** | **long** | the desired final size in MB of the directory, not a diff from the current size; should be more than current size  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

