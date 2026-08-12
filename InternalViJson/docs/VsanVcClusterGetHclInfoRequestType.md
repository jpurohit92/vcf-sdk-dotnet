# Vcenter.ViJson.OpenApi.Model.VsanVcClusterGetHclInfoRequestType
The parameters of *VsanVcClusterHealthSystem.VsanVcClusterGetHclInfo*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vCenter cluster. Set to NULL if only intent to get the HCL DB status in general  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 
**IncludeHostsResult** | **bool** | True to include the HCL information for each of host in the cluster.  | [optional] 
**IncludeVendorInfo** | **bool** | Include the vendor tool information in the result  | [optional] 
**EsxRelease** | **string** | The ESXi release version which HCL is computed against  | [optional] 
**QuerySpec** | [**VsanHclQuerySpec**](VsanHclQuerySpec.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

