# Vcenter.ViJson.OpenApi.Model.UpdateClusterPowerStatusRequestType
The parameters of *VsanClusterPowerSystem.UpdateClusterPowerStatus*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster which to update the power status.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ComputeResource*.  | 
**Status** | **string** | The target status needs to be set.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

