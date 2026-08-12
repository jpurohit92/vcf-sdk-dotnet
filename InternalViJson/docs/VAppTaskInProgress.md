# Vcenter.ViJson.OpenApi.Model.VAppTaskInProgress
A specialized TaskInProgress when an operation is performed on a VM and it is failed due to a vApp-level operation is in progress.  For example, while the power-on sequence is executed on a vApp, individual power-on's of child VMs are failed. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The task already in progress when the operation was attempted.  Refers instance of *Task*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

