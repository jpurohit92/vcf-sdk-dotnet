# Vcenter.ViJson.OpenApi.Model.PerfEntityMetricCSV

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Performance provider ID.  | 
**SampleInfoCSV** | **string** | The *PerfSampleInfo* encoded in the following CSV format: \\[interval1\\], \\[date1\\], \\[interval2\\], \\[date2\\], and so on.  | 
**Value** | [**List&lt;PerfMetricSeriesCSV&gt;**](PerfMetricSeriesCSV.md) | Metric values corresponding to the samples collected in this list.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

