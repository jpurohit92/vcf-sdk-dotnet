# Vcenter.ViJson.OpenApi.Model.VsanClusterNetworkPerfTaskSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster against which network performance test will be run.  It could be the local vSAN cluster or the remote vSAN cluster whose datastore has been mounted to the local cluster. If not specified, it will run against the local vSAN cluster itself.  Refers instance of *ClusterComputeResource*.  | [optional] 
**DurationSec** | **int** | The duration of the network performance test.  Default is 15 seconds if not set.  | [optional] 
**OwnerVc** | **string** | The owner vCenter server FQDN or ip address for the given cluster parameter in this spec.  It can be unset if the cluster is from local VC but should be set for the vSAN cluster from remote VC when it&#39;s mounted as remote vSAN datastore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

