# Vcenter.ViJson.OpenApi.Model.RemoveDiskMappingExRequestType
The parameters of *VimClusterVsanVcDiskManagementSystem.RemoveDiskMappingEx*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vSAN cluster which owns the given disk mapping(s).  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**Mappings** | [**List&lt;VsanHostDiskMapping&gt;**](VsanHostDiskMapping.md) | List of disk mapping(s) to be removed.  | 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Specifies the data evacuation mode.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

