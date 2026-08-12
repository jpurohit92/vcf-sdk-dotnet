# Vcenter.ViJson.OpenApi.Model.CnsCursor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Offset** | **long** | Offset value.  These many results will be skipped and not included in result.  | 
**Limit** | **long** | Limit value sets upper cap for maximum number of values to be included in result.  Default value for limit is 100 and maximum is 1000 (implementation dependent. Subject to change).    If a value higher than maximum allowed is set in input, it will be limited to the maximum.  | 
**TotalRecords** | **long** | This is the total number of records for given input parameters.     This value should be used by client to decide if there is a need to make further calls to server. Client request with offset greater than total number of records would have empty result.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

