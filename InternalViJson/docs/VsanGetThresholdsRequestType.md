# Vcenter.ViJson.OpenApi.Model.VsanGetThresholdsRequestType
The parameters of *VsanDiagnosticsSystem.VsanGetThresholds*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster where the threshold is to get from  Refers instance of *ComputeResource*.  | 
**EntityType** | **string** | Get threshold only for the specified entity type.  | [optional] 
**Metric** | **string** | Get threshold only for the specified metric, \&quot;entityType\&quot; must also be set if \&quot;metric\&quot; is set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

