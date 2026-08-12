# Vcenter.ViJson.OpenApi.Model.ScheduledTaskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the scheduled task.  | 
**Description** | **string** | Description of the scheduled task.  | 
**Enabled** | **bool** | Flag to indicate whether the scheduled task is enabled or disabled.  | 
**Scheduler** | [**TaskScheduler**](TaskScheduler.md) | The time scheduler that determines when the scheduled task runs.  | 
**Action** | [**Action**](Action.md) | The action of the scheduled task, to be done when the scheduled task runs.  | 
**Notification** | **string** | The email notification.  If not set, this property is set to empty string, indicating no notification.  | [optional] 
**ScheduledTask** | [**ManagedObjectReference**](ManagedObjectReference.md) | Scheduled task object.  Refers instance of *ScheduledTask*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity on which related events will be logged.  If the task is scheduled on a ManagedEntity, this field will also reflect the same ManagedEntity. If task is scheduled on a ManagedObject, this field will have information about the entity on which the events will be logged on behalf of the ManagedObject. ManagedObject itself will be denoted by *ScheduledTaskInfo.taskObject*  Refers instance of *ManagedEntity*.  | 
**LastModifiedTime** | **DateTime** | The time the scheduled task is created or modified.  | 
**LastModifiedUser** | **string** | Last user that modified the scheduled task.  | 
**NextRunTime** | **DateTime** | The next time the scheduled task will run.  | [optional] 
**PrevRunTime** | **DateTime** | The last time the scheduled task ran.  | [optional] 
**State** | **TaskInfoStateEnum** | Scheduled task state.  | 
**Error** | [**MethodFault**](MethodFault.md) | The fault code when the scheduled task state is \&quot;error\&quot;.  | [optional] 
**Result** | [**Any**](Any.md) | The operation result when the scheduled task state is \&quot;success\&quot;.  | [optional] 
**Progress** | **int** | The task progress when the scheduled task state is \&quot;running\&quot;.  | [optional] 
**ActiveTask** | [**ManagedObjectReference**](ManagedObjectReference.md) | The running task instance when the scheduled task state is \&quot;running\&quot;.  Refers instance of *Task*.  | [optional] 
**TaskObject** | [**ManagedObjectReference**](ManagedObjectReference.md) | The object on which the scheduled task is defined.  This field will have information about either the ManagedEntity or the ManagedObject on which the scheduled task is defined.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

