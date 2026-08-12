# Vcenter.ViJson.OpenApi.Model.VsanHealthIsRebalanceRunningRequestType
The parameters of *VsanVcClusterHealthSystem.VsanHealthIsRebalanceRunning*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vCenter cluster.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**TargetHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Leave this unset  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

