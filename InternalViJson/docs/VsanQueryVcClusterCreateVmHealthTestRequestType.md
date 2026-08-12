# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterCreateVmHealthTestRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterCreateVmHealthTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster  ***Required privileges:*** VirtualMachine.Inventory.Create VirtualMachine.Inventory.Delete  Refers instance of *ClusterComputeResource*.  | 
**Timeout** | **int** | The timeout in seconds for the VM creation test. The suggested value could be 2 minutes  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore where the VM creation test will be run. It could be the local datastore or the remote datastore that is mounted to the cluster. By default it will run with local vSAN datastore.  Refers instance of *Datastore*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

