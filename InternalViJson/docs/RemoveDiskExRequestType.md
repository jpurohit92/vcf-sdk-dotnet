# Vcenter.ViJson.OpenApi.Model.RemoveDiskExRequestType
The parameters of *VimClusterVsanVcDiskManagementSystem.RemoveDiskEx*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vSAN cluster which owns the given vSAN disk(s) and(or) vSAN direct disk(s).  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**Disks** | [**List&lt;HostScsiDisk&gt;**](HostScsiDisk.md) | List of vSAN disk(s) to be removed.  | 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Specifies the data evacuation mode.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

