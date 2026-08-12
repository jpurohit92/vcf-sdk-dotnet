# Vcenter.ViJson.OpenApi.Model.VsanVitAddIscsiTargetToGroupRequestType
The parameters of *VsanIscsiTargetSystem.VsanVitAddIscsiTargetToGroup*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | : reference to cluster resource.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**InitiatorGroupName** | **string** | : the initiator group name.  | 
**TargetAlias** | **string** | : the iSCSI target alias.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

