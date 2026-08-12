# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterCreateVmHealthHistoryTestRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterCreateVmHealthHistoryTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vCenter cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Count** | **int** | Collect the last test data for the given number at most. Default to get the latest one historical data  | [optional] 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the create vm test has been run. It could be the local datastore or the remote datastore that is mounted to the cluster. By default it will run with local vSAN datastore.  Refers instance of *Datastore*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

