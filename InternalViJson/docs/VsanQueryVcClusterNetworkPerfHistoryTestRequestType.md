# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterNetworkPerfHistoryTestRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterNetworkPerfHistoryTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vCenter cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Count** | **int** | Collect the last test data for the given number at most. Default to get the latest one historical data.  | [optional] 
**Spec** | [**VsanClusterNetworkPerfTaskSpec**](VsanClusterNetworkPerfTaskSpec.md) | The additional query spec for query network performance health test history.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

