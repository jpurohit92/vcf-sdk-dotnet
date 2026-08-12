# Vcenter.ViJson.OpenApi.Model.VsanPerfDiagnoseQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The start time of the period for which the cluster performance will be diagnosed.  This parameter must be specified.  | 
**EndTime** | **DateTime** | The end time of the period for which the cluster performance will be diagnosed.  This parameter must be specified.  | 
**QueryType** | **string** | The query type for which the cluster performance will be diagnosed.  See also *VsanPerfDiagnosticQueryType_enum*.  | 
**Context** | **string** | Any additional context that can be supplied as a hint to the diagnosis.  As an example, if for HCIBench workloads, the string &#39;HCIBench&#39; can be supplied here.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

