# Vcenter.ViJson.OpenApi.Model.VsanStretchedClusterConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vSAN cluster to add/replace witness host.  Refers instance of *ClusterComputeResource*.  | 
**PreferredFdName** | **string** | User friendly name of preferred Fault Domain configured in target cluster.  | [optional] 
**FaultDomainConfig** | [**VimClusterVSANStretchedClusterFaultDomainConfig**](VimClusterVSANStretchedClusterFaultDomainConfig.md) | The mapping between Fault Domain and vSAN hosts reside in target cluster, to decide how to configure vSAN cluster into two sites.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

