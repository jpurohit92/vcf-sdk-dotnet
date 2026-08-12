# Vcenter.ViJson.OpenApi.Model.TaskInfoFilterSpecFilterTaskResults

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoveAll** | **bool** | Excludes results information of all tasks.  If set to true, the results information of all tasks will be excluded.  | [optional] 
**DescriptionIds** | **List&lt;string&gt;** | The description IDs of tasks that have to be filtered out.  The *TaskInfoFilterSpecFilterTaskResults.filterIn* option can switch the behavior to filter in.  | [optional] 
**FilterIn** | **bool** | Boolean Flag to invert the filter semantics to filter in the results instead of filtering out.  If set to true, then the results of only the tasks specified by the *TaskInfoFilterSpecFilterTaskResults.descriptionIds* will be included. If unset or set to false, then the results of only the tasks specified by the *TaskInfoFilterSpecFilterTaskResults.descriptionIds* will be excluded. This boolean flag will only be considered if descriptionsIds is non-empty and if removeAll is false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

