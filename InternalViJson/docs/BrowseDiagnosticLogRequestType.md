# Vcenter.ViJson.OpenApi.Model.BrowseDiagnosticLogRequestType
The parameters of *DiagnosticManager.BrowseDiagnosticLog*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Specifies the host. If not specified, then it defaults to the default server. For example, if called on VirtualCenter, then the value defaults to VirtualCenter logs.  Refers instance of *HostSystem*.  | [optional] 
**Key** | **string** | A string key specifying the key for the log file to browse. Keys can be obtained using the queryDescriptions method.  | 
**Start** | **int** | The line number for the first entry to be returned. If the parameter is not specified, then the operation returns with lines starting from the top of the log.  | [optional] 
**Lines** | **int** | The number of lines to return. If not specified, then all lines are returned from the start value to the end of the file.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

