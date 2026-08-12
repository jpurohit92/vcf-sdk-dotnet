# Vcenter.ViJson.OpenApi.Model.VsanQueryPhysicalPlacementsRequestType
The parameters of *VsanObjectSystem.VsanQueryPhysicalPlacements*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vSAN cluster. This parameter is only applicable for cluster-level API calls.  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | 
**Specs** | [**VsanQueryPhysicalPlacementSpecs**](VsanQueryPhysicalPlacementSpecs.md) | The query specifications for the objects. Multiple object specifications are supported. If unset, the method will return an empty result.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

