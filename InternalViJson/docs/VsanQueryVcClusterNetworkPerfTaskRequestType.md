# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterNetworkPerfTaskRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterNetworkPerfTask*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Spec** | [**VsanClusterNetworkPerfTaskSpec**](VsanClusterNetworkPerfTaskSpec.md) | The additional query spec for network performance health  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

