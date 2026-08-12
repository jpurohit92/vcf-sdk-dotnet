# Vcenter.ViJson.OpenApi.Model.StartIODiagnosticsTaskRequestType
The parameters of *VsanDiagnosticsSystem.StartIODiagnosticsTask*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Targets** | [**List&lt;VsanIODiagnosticsTarget&gt;**](VsanIODiagnosticsTarget.md) | The targets to run the diagnostics.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster where the targets belong to, ignored when calling against ESXi hosts.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ClusterComputeResource*.  | [optional] 
**Duration** | **long** | The duration time in seconds to run diagnostics. The valid range is \\[300, 3600\\], default is 300.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

