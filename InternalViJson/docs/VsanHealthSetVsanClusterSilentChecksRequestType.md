# Vcenter.ViJson.OpenApi.Model.VsanHealthSetVsanClusterSilentChecksRequestType
The parameters of *VsanVcClusterHealthSystem.VsanHealthSetVsanClusterSilentChecks*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vCenter cluster  Refers instance of *ClusterComputeResource*.  | 
**AddSilentChecks** | **List&lt;string&gt;** | The health checks/groups to silent.  | [optional] 
**RemoveSilentChecks** | **List&lt;string&gt;** | The health checks/groups to restore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

