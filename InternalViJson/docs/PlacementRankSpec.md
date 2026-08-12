# Vcenter.ViJson.OpenApi.Model.PlacementRankSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Specs** | [**List&lt;PlacementSpec&gt;**](PlacementSpec.md) | List of VM placement specifications for ranking clusters  | 
**Clusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of candidate clusters for the placement request  Refers instances of *ClusterComputeResource*.  | 
**Rules** | [**List&lt;PlacementAffinityRule&gt;**](PlacementAffinityRule.md) | List of affinity rules for the placement request  | [optional] 
**PlacementRankByVm** | [**List&lt;StorageDrsPlacementRankVmSpec&gt;**](StorageDrsPlacementRankVmSpec.md) | List of preferred clusters for individual VM placement requests  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

