# Vcenter.ViJson.OpenApi.Model.VsanPerfQueryTimeRangesRequestType
The parameters of *VsanPerformanceManager.VsanPerfQueryTimeRanges*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 
**QuerySpec** | [**VsanPerfTimeRangeQuerySpec**](VsanPerfTimeRangeQuerySpec.md) | Specify the name and time boundaries. See details in *VsanPerfTimeRangeQuerySpec*  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

