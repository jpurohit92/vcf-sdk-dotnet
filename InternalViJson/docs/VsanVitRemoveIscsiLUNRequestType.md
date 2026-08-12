# Vcenter.ViJson.OpenApi.Model.VsanVitRemoveIscsiLUNRequestType
The parameters of *VsanIscsiTargetSystem.VsanVitRemoveIscsiLUN*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | : reference to cluster resource.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**TargetAlias** | **string** | : iSCSI target alias.  | 
**LunId** | **int** | : iSCSI LUN id.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

