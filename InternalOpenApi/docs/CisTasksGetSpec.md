# Vcenter.Automation.OpenApi.Model.CisTasksGetSpec
The Cis.Tasks.GetSpec schema describes what data should be included when retrieving information about a task.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnAll** | **bool** | If true, all data, including operation-specific data, will be returned, otherwise only the data described in *Cis.Task.Info* will be returned.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, only the data described in *Cis.Task.Info* will be returned. | [optional] 
**ExcludeResult** | **bool** | If true, the result will not be included in the task information, otherwise it will be included.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60;, the result of the operation will be included in the task information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

