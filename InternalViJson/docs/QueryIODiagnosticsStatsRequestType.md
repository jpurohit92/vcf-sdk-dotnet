# Vcenter.ViJson.OpenApi.Model.QueryIODiagnosticsStatsRequestType
The parameters of *VsanDiagnosticsSystem.QueryIODiagnosticsStats*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceName** | **string** | The completed diagnostics instance name.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster where the diagnostics is performed.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

