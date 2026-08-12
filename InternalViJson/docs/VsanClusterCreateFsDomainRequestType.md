# Vcenter.ViJson.OpenApi.Model.VsanClusterCreateFsDomainRequestType
The parameters of *VsanFileServiceSystem.VsanClusterCreateFsDomain*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainConfig** | [**VsanFileServiceDomainConfig**](VsanFileServiceDomainConfig.md) | Domain configuration information.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

