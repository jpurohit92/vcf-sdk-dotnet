# Vcenter.ViJson.OpenApi.Model.SmsTaskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The unique key for the task.  | 
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object that represents this task.  Refers instance of *SmsTask*.  | 
**Object** | [**ManagedObjectReference**](ManagedObjectReference.md) | Managed Object to which the operation applies.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If the task state is \&quot;error\&quot;, then this property contains the fault code.  | [optional] 
**Result** | [**Any**](Any.md) | If the task state is \&quot;success\&quot;, then this property may be used to hold a return value.  | [optional] 
**StartTime** | **DateTime** | Time stamp when the task started running.  | [optional] 
**CompletionTime** | **DateTime** | Time stamp when the task was completed (whether success or failure).  | [optional] 
**State** | **string** | Runtime status of the task.  Possible values are *SmsTaskState_enum*  | 
**Progress** | **int** | If the task state is \&quot;running\&quot;, then this property contains a progress measurement, expressed as percentage completed, from 0 to 100.  If this property is not set, then the command does not report progress.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

