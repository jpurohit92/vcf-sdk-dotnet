# Vcenter.ViJson.OpenApi.Model.VslmTaskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The unique key for the task.  | 
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object that represents this task.  Refers instance of *VslmTask*.  | 
**Description** | [**LocalizableMessage**](LocalizableMessage.md) | The description field of the task describes the current phase of operation of the task.  For a task that does a single monolithic activity, this will be fixed and unchanging. For tasks that have various substeps, this field will change as the task progresses from one phase to another.  | [optional] 
**Name** | **string** | The name of the operation that created the task.  This is not set for internal tasks.  | [optional] 
**DescriptionId** | **string** | An identifier for this operation.  This includes publicly visible internal tasks and is a lookup in the TaskDescription methodInfo data object.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Managed entity to which the operation applies.  Refers instance of *ManagedEntity*.  | [optional] 
**EntityName** | **string** | The name of the managed entity, locale-specific, retained for the history collector database.  | [optional] 
**Locked** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If the state of the task is \&quot;running\&quot;, then this property is a list of managed entities that the operation has locked, with a shared lock.  Refers instances of *ManagedEntity*.  | [optional] 
**State** | **VslmTaskInfoStateEnum** | Runtime status of the task.  | 
**Cancelled** | **bool** | Flag to indicate whether or not the client requested cancellation of the task.  | 
**Cancelable** | **bool** | Flag to indicate whether or not the cancel task operation is supported.  | 
**Error** | [**MethodFault**](MethodFault.md) | If the task state is \&quot;error\&quot;, then this property contains the fault code.  | [optional] 
**Result** | [**Any**](Any.md) | If the task state is \&quot;success\&quot;, then this property may be used to hold a return value.  | [optional] 
**Progress** | **int** | If the task state is \&quot;running\&quot;, then this property contains a progress measurement, expressed as percentage completed, from 0 to 100.  If this property is not set, then the command does not report progress.  | [optional] 
**Reason** | [**VslmTaskReason**](VslmTaskReason.md) | Kind of entity responsible for creating this task.  | 
**QueueTime** | **DateTime** | Time stamp when the task was created.  | 
**StartTime** | **DateTime** | Time stamp when the task started running.  | [optional] 
**CompleteTime** | **DateTime** | Time stamp when the task was completed (whether success or failure).  | [optional] 
**EventChainId** | **int** | Event chain ID that leads to the corresponding events.  | 
**ChangeTag** | **string** | The user entered tag to identify the operations and their side effects  | [optional] 
**ParentTaskKey** | **string** | Tasks can be created by another task.  This shows *VslmTaskInfo.key* of the task spun off this task. This is to track causality between tasks.  | [optional] 
**RootTaskKey** | **string** | Tasks can be created by another task and such creation can go on for multiple levels.  This is the *VslmTaskInfo.key* of the task that started the chain of tasks.  | [optional] 
**ActivationId** | **string** | The activation Id is a client-provided token to link an API call with a task.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

