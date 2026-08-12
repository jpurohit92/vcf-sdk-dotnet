# Vcenter.ViJson.OpenApi.Model.VsanPerformSiteMaintenancePrecheckRequestType
The parameters of *VsanSiteMaintenanceSystem.VsanPerformSiteMaintenancePrecheck*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster on which to run the precheck.  ***Required privileges:*** Host.Config.Maintenance  Refers instance of *ClusterComputeResource*.  | 
**Spec** | [**VsanSiteMaintenanceSpec**](VsanSiteMaintenanceSpec.md) | The specification of the queried fault domain maintenance action.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

