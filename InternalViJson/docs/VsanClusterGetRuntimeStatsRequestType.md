# Vcenter.ViJson.OpenApi.Model.VsanClusterGetRuntimeStatsRequestType
The parameters of *VsanVcClusterConfigSystem.VsanClusterGetRuntimeStats*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vCenter cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Stats** | **List&lt;string&gt;** | List of vSAN runtime stats type. Supported vSAN runtime stats types are declared in *VsanHostStatsType_enum*. If this parameter is omitted, all supported runtime stats will be collected and returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

