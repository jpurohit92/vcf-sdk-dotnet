# Vcenter.ViJson.OpenApi.Model.VsanVitRemoveIscsiInitiatorsFromTargetRequestType
The parameters of *VsanIscsiTargetSystem.VsanVitRemoveIscsiInitiatorsFromTarget*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | : reference to cluster resource.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**TargetAlias** | **string** | : target alias.  | 
**InitiatorNames** | **List&lt;string&gt;** | : initiator or initiator group name list.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

