# Vcenter.ViJson.OpenApi.Model.VsanSiteMaintenanceCheckTaskDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object of the task.  Refers instance of *Task*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object of the host on which the task is running.  Refers instance of *HostSystem*.  | [optional] 
**HostUuid** | **string** | The vSAN UUID of the host on which the task is running.  | [optional] 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | The host maintenance spec specifying the data evacuation mode that the task is running with.  | [optional] 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object of the cluster on which the task is running.  Refers instance of *ClusterComputeResource*.  | 
**SiteMaintenanceSpec** | [**VsanSiteMaintenanceSpec**](VsanSiteMaintenanceSpec.md) | The specification of fault domain maintenance precheck task.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

