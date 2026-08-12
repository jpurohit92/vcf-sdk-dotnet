# Vcenter.ViJson.OpenApi.Model.VsanResourceCheckSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The operation for which the resource check is performed: - \&quot;EnterMaintenanceMode\&quot;: The resource check for host enter maintenance   mode operation. - \&quot;DiskDataEvacuation\&quot;: The resource check for vSAN disk or disk-group   operation which requires vSAN disk data evacuation (e.g., unmount   a vSAN disk-group, remove a vSAN disk/disk-group, rebuild a vSAN   disk-group, etc.).  | 
**Entities** | **List&lt;string&gt;** | The list of entity vSAN UUIDs against which the resource check is performed.  For host enter maintenance operation, only one host vSAN UUID is supported at a time.  | [optional] 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | The host maintenance spec specifying the data evacuation mode.  | [optional] 
**Parent** | [**ManagedObjectReference**](ManagedObjectReference.md) | Specify the task if this resource check is called from a running task.  Refers instance of *Task*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

