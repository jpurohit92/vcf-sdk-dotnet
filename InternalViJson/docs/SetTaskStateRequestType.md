# Vcenter.ViJson.OpenApi.Model.SetTaskStateRequestType
The parameters of *Task.SetTaskState*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **TaskInfoStateEnum** | New state for task  | 
**Result** | [**Any**](Any.md) | Result to set, valid only if task state is TaskInfo.State.success  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Fault to set, valid only if task state is *error*. The fault must be a of a fault type that directly or indirectly extends *VimFault*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

