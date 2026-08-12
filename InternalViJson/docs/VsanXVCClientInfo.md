# Vcenter.ViJson.OpenApi.Model.VsanXVCClientInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The client cluster which mounts the vSAN datastore across VC.  Refers instance of *ClusterComputeResource*.  | 
**ClusterName** | **string** | The client cluster name which mounts the vSAN datastore across VC.  | 
**VsanFormatVersion** | **string** | The client cluster vSAN format version.  This is stored at server side for vSAN version compatibility check.  | 
**OwnerVc** | **string** | Remote VC address which owns this client cluster  | 
**VcUuid** | **string** | Remote VC uuid which owns this client cluster  | [optional] 
**ClusterUuid** | **string** | The client cluster uuid which mounts the vSAN datastore across VC.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

