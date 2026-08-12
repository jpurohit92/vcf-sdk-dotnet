# Vcenter.ViJson.OpenApi.Model.VsanCreateFileShareRequestType
The parameters of *VsanFileServiceSystem.VsanCreateFileShare*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**VsanFileShareConfig**](VsanFileShareConfig.md) | The file share configuration, as specified in . Note that the backing vSAN object for the file share will be by default 1TB if the file share is thin provisioned. Otherwise the backing vSAN object is set to 255GB if quota is not set.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

