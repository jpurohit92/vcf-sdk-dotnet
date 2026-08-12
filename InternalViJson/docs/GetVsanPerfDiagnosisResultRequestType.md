# Vcenter.ViJson.OpenApi.Model.GetVsanPerfDiagnosisResultRequestType
The parameters of *VsanPerformanceManager.GetVsanPerfDiagnosisResult*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | Task returned by VsanPerfDiagnoseTask  Refers instance of *Task*.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster. Ignored if called against host.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

