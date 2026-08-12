# Vcenter.ViJson.OpenApi.Model.RemoveDiskRequestType
The parameters of *HostVsanSystem.RemoveDisk_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | [**List&lt;HostScsiDisk&gt;**](HostScsiDisk.md) | list of disks to be removed from use by the VSAN service.  | 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Any additional actions to move data out of the disk before removing it. See *HostMaintenanceSpec*. If unspecified, there is no action taken to move data from the disk.  | [optional] 
**Timeout** | **int** | Time to wait for the task to complete in seconds. If the value is less than or equal to zero, there is no timeout. The operation fails with a Timedout exception if it timed out.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

