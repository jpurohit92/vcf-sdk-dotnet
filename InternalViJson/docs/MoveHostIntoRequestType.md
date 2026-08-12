# Vcenter.ViJson.OpenApi.Model.MoveHostIntoRequestType
The parameters of *ClusterComputeResource.MoveHostInto_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The list of hosts to move into the cluster.  ***Required privileges:*** Host.Inventory.MoveHost  Refers instance of *HostSystem*.  | 
**ResourcePool** | [**ManagedObjectReference**](ManagedObjectReference.md) | The resource pool to match the root resource pool of stand-alone hosts. This argument has no effect if the host is part of a cluster.  Refers instance of *ResourcePool*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

