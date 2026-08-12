# Vcenter.ViJson.OpenApi.Model.QueryFileLockInfoRequestType
The parameters of *FileManager.QueryFileLockInfo*.  ***Since:*** vSphere API Release 8.0.2.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Full file path to look up lock information on. For example specific VM file like: /vmfs/volumes/datastore1/vm/vm-flat.vmdk  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host id is required if API is invoked on vCenter Server. It is optional if invoked on host directly. Esx does not require this parameter.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

