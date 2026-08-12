# Vcenter.ViJson.OpenApi.Model.VsanSetThresholdsRequestType
The parameters of *VsanDiagnosticsSystem.VsanSetThresholds*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster where the threshold is to set to  Refers instance of *ComputeResource*.  | 
**Thresholds** | [**List&lt;VsanDiagnosticsThreshold&gt;**](VsanDiagnosticsThreshold.md) | The new threshold value to set  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

