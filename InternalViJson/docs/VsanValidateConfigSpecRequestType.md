# Vcenter.ViJson.OpenApi.Model.VsanValidateConfigSpecRequestType
The parameters of *VsanVcClusterConfigSystem.VsanValidateConfigSpec*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target VC cluster to apply reconfig spec  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**VsanReconfigSpec** | [**VimVsanReconfigSpec**](VimVsanReconfigSpec.md) | The configure spec to be validated  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

