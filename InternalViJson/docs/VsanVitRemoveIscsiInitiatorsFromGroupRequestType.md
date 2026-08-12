# Vcenter.ViJson.OpenApi.Model.VsanVitRemoveIscsiInitiatorsFromGroupRequestType
The parameters of *VsanIscsiTargetSystem.VsanVitRemoveIscsiInitiatorsFromGroup*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | : reference to cluster resource.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**InitiatorGroupName** | **string** | : the initiator group name.  | 
**InitiatorNames** | **List&lt;string&gt;** | : the initiator name list.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

