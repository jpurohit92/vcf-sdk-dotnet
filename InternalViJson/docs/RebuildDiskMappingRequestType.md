# Vcenter.ViJson.OpenApi.Model.RebuildDiskMappingRequestType
The parameters of *VimClusterVsanVcDiskManagementSystem.RebuildDiskMapping*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target host to rebuild.  ***Required privileges:*** Host.Config.Storage  Refers instance of *HostSystem*.  | 
**Mapping** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | The disk mapping to be rebuilt from VSAN usage.  | 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Specifies the data evacuation mode.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

