# Vcenter.ViJson.OpenApi.Model.VsanPerfDiagnosticResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExceptionId** | **string** | The exception Id identifying a cause of poor performance.  Use GetSupportedDiagnosticExceptions to get more details for the particular exceptionId  | 
**Recommendation** | **string** | The recommendation message explaining what can be done to avoid this performance exception.  | [optional] 
**AggregationFunction** | **string** | In case an aggregation is applied to raw performance service data, this field denotes the aggregation function.  Examples are: spread, max, min, sum, compare, etc. If an aggregation is not applied, this field is empty.  | [optional] 
**AggregationData** | [**VsanPerfEntityMetricCSV**](VsanPerfEntityMetricCSV.md) | A time series data that identifies the result of the aggregation applied to raw data returned by performance service.  When this field is empty, it implies that no aggregation operation was performed for this exception. The entityRefId captures the unique entity type being aggregated. This could either be a single entity type, such as, capacity-disk, or it could be denoting a comparison between two entities, such as, cluster-domclient/diskgroup. The value field (VsanPerfMetricSeriesCSV) will contain the unique metricIds for which the aggregation is computed. Just like entityRefId, this could be a single metric, e.g. latencyRead, or a comparison between two metrics, such as throughputRead/iopsRead. The values field will contain the result of the aggregation operation in CSV.  | [optional] 
**ExceptionData** | [**List&lt;VsanPerfEntityMetricCSV&gt;**](VsanPerfEntityMetricCSV.md) | An array of time series data that identifies why this performance exception was raised.  When this array has multiple elements, aggregatedFunction will identify the aggregation function applied on the raw data to get the end result which identifies a performance exception. Each time series is of type VsanPerfEntityMetricCSV and is an independent cause of the performance exception. The entityRefId in VsanPerfEntityMetricCSV would refer to an entity type which is limiting performance, such as, a diskgroup. The values in VsanPerfEntityMetricCSV (VsanPerfMetricSeriesCSV) contain the metricId for which the exception was raised, and the values corresponding to the queried time.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

