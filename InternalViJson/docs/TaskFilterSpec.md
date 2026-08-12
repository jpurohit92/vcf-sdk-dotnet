# Vcenter.ViJson.OpenApi.Model.TaskFilterSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**TaskFilterSpecByEntity**](TaskFilterSpecByEntity.md) | The filter specification for retrieving tasks by managed entity.  If not provided, then the tasks attached to all managed entities are collected.  | [optional] 
**Time** | [**TaskFilterSpecByTime**](TaskFilterSpecByTime.md) | The filter specification for retrieving tasks by time.  If not provided, then the tasks with any time stamp are collected.  | [optional] 
**UserName** | [**TaskFilterSpecByUsername**](TaskFilterSpecByUsername.md) | The filter specification for retrieving tasks by user name.  If not provided, then the tasks belonging to any user are collected.  | [optional] 
**ActivationId** | **List&lt;string&gt;** | This property, if provided, limits the set of collected tasks to those associated with the specified activation Ids.  | [optional] 
**State** | [**List&lt;TaskInfoStateEnum&gt;**](TaskInfoStateEnum.md) | This property, if provided, limits the set of collected tasks by their states.  Task states are enumerated in *State*. If not provided, tasks are collected regardless of their state.  | [optional] 
**Alarm** | [**ManagedObjectReference**](ManagedObjectReference.md) | This property, if provided, limits the set of collected tasks to those associated with the specified alarm.  If not provided, tasks are collected regardless of their association with alarms.  Refers instance of *Alarm*.  | [optional] 
**ScheduledTask** | [**ManagedObjectReference**](ManagedObjectReference.md) | This property, if provided, limits the set of collected tasks to those associated with the specified scheduled task.  If not provided, tasks are collected regardless of their association with any scheduled task.  Refers instance of *ScheduledTask*.  | [optional] 
**EventChainId** | **List&lt;int&gt;** | The filter specification for retrieving tasks by chain ID.  If it is set, tasks not with the given *TaskInfo.eventChainId* will be filtered out. If the property is not set, tasks&#39; chain ID is disregarded for filtering purposes.  | [optional] 
**Tag** | **List&lt;string&gt;** | The filter specification for retrieving tasks by *tag*.  If it is set, tasks not with the given tag(s) will be filtered out. If the property is not set, tasks&#39; tag is disregarded for filtering purposes. If it is set, and includes an empty string, tasks without a tag will be returned.  | [optional] 
**ParentTaskKey** | **List&lt;string&gt;** | The filter specification for retrieving tasks by *TaskInfo.parentTaskKey*.  If it is set, tasks not with the given parentTaskKey(s) will be filtered out. If the property is not set, tasks&#39; parentTaskKey is disregarded for filtering purposes.  | [optional] 
**RootTaskKey** | **List&lt;string&gt;** | The filter specification for retrieving tasks by *TaskInfo.rootTaskKey*.  If it is set, tasks not with the given rootTaskKey(s) will be filtered out. If the property is not set, tasks&#39; rootTaskKey is disregarded for filtering purposes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

