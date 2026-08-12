# Vcenter.ViJson.OpenApi.Model.CnsVolumeMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerCluster** | [**CnsContainerCluster**](CnsContainerCluster.md) | Deprecated as of vSphere 7.0. Use *CnsEntityMetadata* to refer to the container cluster the entity belongs to.  Represents the container orchestrator cluster where the volume is used.     Volume metadata will be associated with the container volume for this container cluster during volume create and update operations. In case the block container volume is created in one container cluster but used in a different container cluster (static volume provisioning use case), an update volume operation with a new container cluster will replace the old entry.  | 
**EntityMetadata** | [**List&lt;CnsEntityMetadata&gt;**](CnsEntityMetadata.md) | All the entity metadata associated with the container volume within a container orchestrator like Kubernetes.  | [optional] 
**ContainerClusterArray** | [**List&lt;CnsContainerCluster&gt;**](CnsContainerCluster.md) | Represents list of all container orchestrator clusters where the volume is used.  This field is mandatory in versions that support it.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

