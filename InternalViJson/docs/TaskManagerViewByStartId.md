# Vcenter.ViJson.OpenApi.Model.TaskManagerViewByStartId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | The page size to be fetched.  When the value is &amp;gt; 0, the query will fetch tasks older than the specified task in *TaskManagerViewByStartId.startId* parameter with lesser task IDs. (Next page when the tasks are shown with the newest task first) When the value is &amp;lt; 0, the query will fetch tasks newer than the specified task in *TaskManagerViewByStartId.startId* parameter with greater task IDs. (Previous page when the tasks are shown with the newest task first)  | 
**StartId** | **string** | Specifies the *TaskInfo.key* of the task from which to start the query.  If it is set to an empty string and *TaskManagerViewByStartId.count* &amp;gt; 0, the query will return the latest (newest) *TaskManagerViewByStartId.count* tasks in the system. In order to read the oldest tasks in the system, the caller should set this field to \&quot;task-0\&quot; and *TaskManagerViewByStartId.count* to a negative number.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

