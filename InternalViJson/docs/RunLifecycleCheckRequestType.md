# Vcenter.ViJson.OpenApi.Model.RunLifecycleCheckRequestType
The parameters of *VsanVcClusterConfigSystem.RunLifecycleCheck*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Cluster on which to perform lifecycle checks and return configuration information.  Refers instance of *ClusterComputeResource*.  | 
**VsanLifecycleCheckSpec** | [**VsanVcLifecycleCheckSpec**](VsanVcLifecycleCheckSpec.md) | Specification for the lifecycle checks.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

