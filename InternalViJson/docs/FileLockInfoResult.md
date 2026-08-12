# Vcenter.ViJson.OpenApi.Model.FileLockInfoResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockInfo** | [**List&lt;FileLockInfo&gt;**](FileLockInfo.md) | FileLockInfo entries populated based on results fetched from host.  If a single path is provided result should contain a single entry. For a generic VM name potentially multiple entries could be fetched and populated. Refer to *FileManager.QueryFileLockInfo* for more details.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

