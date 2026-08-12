# Vcenter.ViJson.OpenApi.Model.CreateTaskRequestType
The parameters of *TaskManager.CreateTask*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Obj** | [**ManagedObjectReference**](ManagedObjectReference.md) | ManagedObject with which Task will be associated  | 
**TaskTypeId** | **string** | Extension registered task type identifier for type of task being created  | 
**InitiatedBy** | **string** | The name of the user on whose behalf the Extension is creating the task  | [optional] 
**Cancelable** | **bool** | True if the task should be cancelable, false otherwise  | 
**ParentTaskKey** | **string** | Key of the task that is the parent of this task  | [optional] 
**ActivationId** | **string** | Activation Id is a client-provided token to link an API call with a task. When provided, the activationId is added to the *TaskInfo*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

