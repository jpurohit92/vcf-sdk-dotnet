# Vcenter.ViJson.OpenApi.Model.VsanHealthRepairClusterObjectsImmediateRequestType
The parameters of *VsanVcClusterHealthSystem.VsanHealthRepairClusterObjectsImmediate*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VC cluster.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**Uuids** | **List&lt;string&gt;** | The object UUIDs need to be repaired. Unset to fix all of objects under the cluster  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

