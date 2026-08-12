# Vcenter.ViJson.OpenApi.Model.VSANVcRemoveWitnessHostRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.VSANVcRemoveWitnessHost*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster to disable;  ***Required privileges:*** Host.Inventory.RemoveHostFromCluster  Refers instance of *ClusterComputeResource*.  | 
**WitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | Witness host to remove;  Refers instance of *HostSystem*.  | [optional] 
**WitnessAddress** | **string** | The IP address of witness host used as unicast agent.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

