# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterNetworkPerfTestRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterNetworkPerfTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Multicast** | **bool** | True to test vSAN multicast network performance. False to test vSAN unicast network performance.  | 
**DurationSec** | **int** | The duration of the Network Performance test. Default is 15 seconds if not set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

