# Vcenter.ViJson.OpenApi.Model.CnsKubernetesEntityMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityName** | **string** | Represents the name of entity.  | 
**Labels** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Labels for this entity.     Labels are opaque to CNS and it will neither try to parse the key nor the value. A maximum of 32 labels will be supported for each entity. Label key should be less than 320 bytes and value should be less than 64 bytes.    If the constraints are not honored, then *InvalidArgument* will be thrown.  | [optional] 
**Delete** | **bool** | If not set, False is assumed. - True indicates that the EntityMetadata should be deleted in   VolumeManager.Update API. - False indicates that the EntityMetadata should be added or replaced   in VolumeManager.Create, VolumeManager.Update APIs.  | [optional] 
**ClusterId** | **string** | Represents the container orchestrator cluster the entity belongs to.  This is a mandatory field as the VolumeMetadata.containerCluster is deprecated.    This field points to a cluster in *CnsVolumeMetadata.containerClusterArray*  | [optional] 
**EntityType** | **string** | Represents the type of entity in Kubernetes.  See *CnsKubernetesEntityType_enum* for supported types.  | 
**Namespace** | **string** | Namespace in Kubernetes the entity belongs to, if applicable.     Namespace must not be set for entity of type persistent volume and must be set for entities of type persistent volume claim and pod.  | [optional] 
**ReferredEntity** | [**List&lt;CnsKubernetesEntityReference&gt;**](CnsKubernetesEntityReference.md) | The Kubernetes entity it is referring to.  For example, a PVC refers to a PV, a Pod refers to one or more PVCs etc. If is perfectly fine for an entity to not refer to anything, example, a PV does not refer to a PVC etc.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

