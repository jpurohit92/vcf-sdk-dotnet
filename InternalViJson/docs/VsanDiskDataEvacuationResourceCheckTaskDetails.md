# Vcenter.ViJson.OpenApi.Model.VsanDiskDataEvacuationResourceCheckTaskDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object of the task.  Refers instance of *Task*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object of the host on which the task is running.  Refers instance of *HostSystem*.  | [optional] 
**HostUuid** | **string** | The vSAN UUID of the host on which the task is running.  | [optional] 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | The host maintenance spec specifying the data evacuation mode that the task is running with.  | [optional] 
**DiskUuid** | **string** | If *VsanResourceCheckSpec.operation* is \&quot;DiskDataEvacuation\&quot;, this will be the vSAN UUID of cache-tier disk or capacity-tier disk in a disk-group depending on whether the task is for a disk-group or a disk.  If the task is for a disk-group, this is the vSAN UUID of the cache-tier disk in the disk-group. If the task is for a disk, this is the vSAN UUID of the corresponding capacity-tier disk.  | [optional] 
**IsCapacityTier** | **bool** | If *VsanResourceCheckSpec.operation* is \&quot;DiskDataEvacuation\&quot;, this flag indicates whether the task is for a disk-group or just a disk.  If the flag is true, the task is for a capacity-tier disk with vSAN UUID in *VsanResourceCheckTaskDetails.hostUuid*; otherwise the task is for a disk-group represented by its cache-tier disk with vSAN UUID in *VsanResourceCheckTaskDetails.hostUuid*. This field could be unset if the backend is not ready to decide on the disk tier information (e.g. disk information query takes longer due to underlying networking delay) or even not able to get the disk tier information (e.g. the host which owns the disk/disk-group gets disconnected or not responding).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

