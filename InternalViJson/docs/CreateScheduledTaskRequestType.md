# Vcenter.ViJson.OpenApi.Model.CreateScheduledTaskRequestType
The parameters of *ScheduledTaskManager.CreateScheduledTask*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed entity (or entities) for which the scheduled task triggers an action. You can schedule tasks on any managed entity. If the scheduled task is associated with a leaf node in the inventory tree, it applies only to a single entity (virtual machine or host). If the task is associated with a folder, a datacenter, a compute resource, or a resource pool, it applies to the virtual machine or host descendants of the entity.  ***Required privileges:*** ScheduledTask.Create  Refers instance of *ManagedEntity*.  | 
**Spec** | [**ScheduledTaskSpec**](ScheduledTaskSpec.md) | The specification for the new scheduled task.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

