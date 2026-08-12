# Vcenter.ViJson.OpenApi.Model.VsanClusterQueryFsDomainsRequestType
The parameters of *VsanFileServiceSystem.VsanClusterQueryFsDomains*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuerySpec** | [**VsanFileServiceDomainQuerySpec**](VsanFileServiceDomainQuerySpec.md) | The specifications of the file service domains to be queried.  | [optional] 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

