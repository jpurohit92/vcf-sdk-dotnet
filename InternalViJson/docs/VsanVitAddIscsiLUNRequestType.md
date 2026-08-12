# Vcenter.ViJson.OpenApi.Model.VsanVitAddIscsiLUNRequestType
The parameters of *VsanIscsiTargetSystem.VsanVitAddIscsiLUN*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | : reference to cluster resource.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**TargetAlias** | **string** | : target alias  | 
**LunSpec** | [**VsanIscsiLUNSpec**](VsanIscsiLUNSpec.md) | : reference to iSCSI LUN specification.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

