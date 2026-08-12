# Vcenter.ViJson.OpenApi.Model.VsanClusterRemoveFsDomainRequestType
The parameters of *VsanFileServiceSystem.VsanClusterRemoveFsDomain*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainUuid** | **string** | The unique domain uuid that is configured in the directory service, for example, Active Directory (AD) from Microsoft.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

