# Vcenter.ViJson.OpenApi.Model.TaskFilterSpecByTime

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeType** | **TaskFilterSpecTimeOptionEnum** | The time stamp to filter: queued, started, or completed time.  | 
**BeginTime** | **DateTime** | The beginning of the time range.  If this property is not specified, then tasks are collected from the earliest time in the database.  When this property is specified, the time type field must also be specified.  | [optional] 
**EndTime** | **DateTime** | The end of the time range.  If this property is not specified, then tasks are collected up to the latest time in the database.  When this property is specified, the time type field must also be specified.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

