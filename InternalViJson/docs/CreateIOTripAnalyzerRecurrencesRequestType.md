# Vcenter.ViJson.OpenApi.Model.CreateIOTripAnalyzerRecurrencesRequestType
The parameters of *VsanDiagnosticsSystem.CreateIOTripAnalyzerRecurrences*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster on which the IO trip analyzer scheduler is configured.  Refers instance of *ComputeResource*.  | 
**Recurrences** | [**List&lt;VsanIOTripAnalyzerRecurrence&gt;**](VsanIOTripAnalyzerRecurrence.md) | The scheduler recurrences configurations.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

