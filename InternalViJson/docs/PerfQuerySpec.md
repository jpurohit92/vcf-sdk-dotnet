# Vcenter.ViJson.OpenApi.Model.PerfQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object whose performance statistics are being queried.  | 
**StartTime** | **DateTime** | The server time from which to obtain counters.  If not specified, defaults to the first available counter. When a startTime is specified, the returned samples do not include the sample at startTime.  | [optional] 
**EndTime** | **DateTime** | The time up to which statistics are retrieved.  Corresponds to server time. When endTime is omitted, the returned result includes up to the most recent metric value. When an endTime is specified, the returned samples include the sample at endTime.  | [optional] 
**MaxSample** | **int** | Limits the number of samples returned.  Defaults to the most recent sample (or samples), unless a time range is specified. Use this property only in conjunction with the *PerfQuerySpec.intervalId* to obtain real-time statistics (set the *PerfQuerySpec.intervalId* to the *PerfProviderSummary.refreshRate*. This property is ignored for historical statistics, and is not valid for the *PerformanceManager.QueryPerfComposite* operation.  | [optional] 
**MetricId** | [**List&lt;PerfMetricId&gt;**](PerfMetricId.md) | The performance metrics to be retrieved.  This property is required for the *PerformanceManager.QueryPerfComposite* operation.  | [optional] 
**IntervalId** | **int** | The interval (*PerfInterval.samplingPeriod*), in seconds, for the performance statistics&amp;#46; For aggregated information, use one of the historical intervals for this property.  See *PerfInterval* for more information. - To obtain the greatest detail, use the provider&amp;#146;s *PerfProviderSummary.refreshRate* for this   property.  | [optional] 
**Format** | **string** | The format to be used while returning the statistics&amp;#46;  See also *PerfFormat_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

