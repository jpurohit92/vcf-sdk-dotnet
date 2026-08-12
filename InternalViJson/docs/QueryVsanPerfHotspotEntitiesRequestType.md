# Vcenter.ViJson.OpenApi.Model.QueryVsanPerfHotspotEntitiesRequestType
The parameters of *VsanPerformanceManager.QueryVsanPerfHotspotEntities*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster, which is ignored if the API is called against host.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 
**QuerySpec** | [**VsanPerfHotspotQuerySpec**](VsanPerfHotspotQuerySpec.md) | Represent query specification to retrieve the desired top entities.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

