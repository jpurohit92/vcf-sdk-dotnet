# Vcenter.ViJson.OpenApi.Model.VsanPerfQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityRefId** | **string** | The &#39;entityRefId&#39; is an entity reference id, which is used to identify the target entity (i.e.  clusters, hosts) you want to query. Here an entity reference id consists of an entity type and an UUID of the entity. Its format is &amp;lt;entity-type&amp;gt;:&amp;lt;entity-uuid&amp;gt;. It is possible to pass &#39;\\*&#39; as the value for entity-uuid in case one wants to query all entities of a certain type. For supported entity types:   See *VsanPerformanceManager.VsanPerfQueryPerf*  | 
**StartTime** | **DateTime** | The startTime is the server time from which to obtain counters.  This field must be specified, and the returned samples do not include the sample at startTime.  | [optional] 
**EndTime** | **DateTime** | The endTime is the server time up to which statistics are retrieved.  This field will be replaced by current server time if it is later than current server time. This field must be specified and the returned samples include the sample at endTime.  | [optional] 
**Group** | **string** | A type of entity (like hosts) may have metrics with same names (i.e.  IOPS, Throughput) in different groups/view-points (i.e. DOMClient, DOMCompMgr). Here the &#39;group&#39; attribute is used to identify which group of metrics is to be queried for an entity. If group is not set, a default group will be used. For supported entity types, metric groups, metrics:   See *VsanPerformanceManager.VsanPerfQueryPerf*  | [optional] 
**Labels** | **List&lt;string&gt;** | The performance metrics (labels) to be retrieved.  The label is also used in VsanPerfMetricId of returned metrics data.  | [optional] 
**Interval** | **int** | The interval, in seconds, for aggregated performance statistics.  Please ignore this field. It is not used in this version.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

