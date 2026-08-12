# Vcenter.ViJson.OpenApi.Model.VsanPerfDiagnoseTaskRequestType
The parameters of *VsanPerformanceManager.VsanPerfDiagnoseTask*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PerfDiagnoseQuery** | [**VsanPerfDiagnoseQuerySpec**](VsanPerfDiagnoseQuerySpec.md) | The query describing details of diagnosis required, such as the period of diagnosis and the query type.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster. Ignored if called against host.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

