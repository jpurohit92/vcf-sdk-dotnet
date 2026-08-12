# Vcenter.ViJson.OpenApi.Model.VsanPerfEntityMetricCSV

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityRefId** | **string** | The entity reference id in format &amp;lt;type&amp;gt;:&amp;lt;id&amp;gt; like managed object reference.  For supported entity types, metric groups, metrics, see *VsanPerformanceManager.VsanPerfQueryPerf*  | 
**SampleInfo** | **string** | The SampleInfo (timestamp,interval) encoded in the following CSV format: \\[date1\\], \\[date2\\], and so on.  | [optional] 
**Value** | [**List&lt;VsanPerfMetricSeriesCSV&gt;**](VsanPerfMetricSeriesCSV.md) | A list of values that corresponds to the samples collected.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

