# Vcenter.ViJson.OpenApi.Model.CnsKubernetesEntityReference

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | Represents the type of entity in Kubernetes.  See *CnsKubernetesEntityType_enum* for supported types.  | 
**EntityName** | **string** | Represents the name of entity.  | 
**Namespace** | **string** | Namespace in Kubernetes the entity belongs to, if applicable.     Namespace must not be set for entity of type persistent volume and must be set for entities of type persistent volume claim and pod.  | [optional] 
**ClusterId** | **string** | Represents the Kubernetes cluster the entity belongs to.  If unset, the server will interpret that this referred entity is in the same Kubernetes cluster as the *CnsKubernetesEntityMetadata.entityType*.    The clusterId should be one of the cluster in *CnsVolumeMetadata.containerClusterArray*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

