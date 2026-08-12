# Vcenter.ViJson.OpenApi.Model.VsanVitAddIscsiInitiatorsToGroupRequestType
The parameters of *VsanIscsiTargetSystem.VsanVitAddIscsiInitiatorsToGroup*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | : reference to cluster resource.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**InitiatorGroupName** | **string** | : the initiator group name.  | 
**InitiatorNames** | **List&lt;string&gt;** | : the iSCSI initiator name list.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

