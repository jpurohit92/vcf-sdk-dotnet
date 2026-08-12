# Vcenter.ViJson.OpenApi.Model.VsanPerfMetricSeriesCSV

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetricId** | [**VsanPerfMetricId**](VsanPerfMetricId.md) | Information about the metric this data object has values for  | 
**Threshold** | [**VsanPerfThreshold**](VsanPerfThreshold.md) | The threshold used by VsanPerfDiagnosticService to indicate the level of performance issue seen in the data.  Only populated in return from GetVsanPerfDiagnosisResult  | [optional] 
**NumExceptions** | **string** | The number of exceptions is used by VsanPerfDiagnosticService to indicate the number of times that the corresponding rule in VsanPerfDiagnosticService sees the threshold getting violated.  Only populated in return from GetVsanPerfDiagnosisResult.  | [optional] 
**Values** | **string** | An array of sample values in CSV format  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

