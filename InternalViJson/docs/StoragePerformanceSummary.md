# Vcenter.ViJson.OpenApi.Model.StoragePerformanceSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **int** | Time period over which statistics are aggregated The reported time unit is in seconds  | 
**Percentile** | **List&lt;int&gt;** | Metric percentile specification.  A percentile is a value between 1 and 100. The metric value reported in the aggregated statistics corresponds with the percentile values in this field. For example, if the value of percentile\\[0\\] is P, and the value of the datastoreReadLatency\\[0\\] is L, then P% of all the read IOs performed during observation interval is less than L milliseconds.  | 
**DatastoreReadLatency** | **List&lt;double&gt;** | Aggregated datastore latency in milliseconds for read operations  | 
**DatastoreWriteLatency** | **List&lt;double&gt;** | Aggregated datastore latency in milliseconds for write operations  | 
**DatastoreVmLatency** | **List&lt;double&gt;** | Aggregated datastore latency as observed by Vms using the datastore The reported latency is in milliseconds.  | 
**DatastoreReadIops** | **List&lt;double&gt;** | Aggregated datastore Read IO rate (Reads/second)  | 
**DatastoreWriteIops** | **List&lt;double&gt;** | Aggregated datastore Write IO rate (Writes/second)  | 
**SiocActivityDuration** | **int** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Cumulative SIOC activity to satisfy SIOC latency threshold setting.  This metric indicates the total time that SIOC is actively throttling IO requests. The SIOC throttling activity occurs whenever the datastore latency exceeds the SIOC latency threshold. If SIOC is not enabled on the datastore, the metric indicates the total time that SIOC would have been active. The unit of reporting is in milliseconds.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

