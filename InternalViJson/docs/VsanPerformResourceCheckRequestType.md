# Vcenter.ViJson.OpenApi.Model.VsanPerformResourceCheckRequestType
The parameters of *VsanResourceCheckSystem.VsanPerformResourceCheck*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceCheckSpec** | [**VsanResourceCheckSpec**](VsanResourceCheckSpec.md) | The specification of the resource check.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to run the resource check.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

