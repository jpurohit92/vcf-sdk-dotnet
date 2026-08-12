# Vcenter.ViJson.OpenApi.Model.CnsEntityMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityName** | **string** | Represents the name of entity.  | 
**Labels** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Labels for this entity.     Labels are opaque to CNS and it will neither try to parse the key nor the value. A maximum of 32 labels will be supported for each entity. Label key should be less than 320 bytes and value should be less than 64 bytes.    If the constraints are not honored, then *InvalidArgument* will be thrown.  | [optional] 
**Delete** | **bool** | If not set, False is assumed. - True indicates that the EntityMetadata should be deleted in   VolumeManager.Update API. - False indicates that the EntityMetadata should be added or replaced   in VolumeManager.Create, VolumeManager.Update APIs.  | [optional] 
**ClusterId** | **string** | Represents the container orchestrator cluster the entity belongs to.  This is a mandatory field as the VolumeMetadata.containerCluster is deprecated.    This field points to a cluster in *CnsVolumeMetadata.containerClusterArray*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

