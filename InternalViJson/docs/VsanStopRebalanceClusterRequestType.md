# Vcenter.ViJson.OpenApi.Model.VsanStopRebalanceClusterRequestType
The parameters of *VsanVcClusterHealthSystem.VsanStopRebalanceCluster*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vCenter cluster  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**TargetHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Leave this unset  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

