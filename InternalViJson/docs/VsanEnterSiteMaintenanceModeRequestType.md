# Vcenter.ViJson.OpenApi.Model.VsanEnterSiteMaintenanceModeRequestType
The parameters of *VsanSiteMaintenanceSystem.VsanEnterSiteMaintenanceMode*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaultDomainName** | **string** | The fault domain name to enter maintenance mode.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster containing the fault domain to enter maintenance mode.  Refers instance of *ClusterComputeResource*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

