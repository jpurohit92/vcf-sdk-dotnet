# Vcenter.ViJson.OpenApi.Model.VsanSetDpClusterSilentChecksRequestType
The parameters of *DataProtectionHealthSystem.VsanSetDpClusterSilentChecks*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target data protection protected cluster  Refers instance of *ClusterComputeResource*.  | 
**AddSilentChecks** | **List&lt;string&gt;** | The health checks/groups to silent.  | [optional] 
**RemoveSilentChecks** | **List&lt;string&gt;** | The health checks/groups to restore.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

