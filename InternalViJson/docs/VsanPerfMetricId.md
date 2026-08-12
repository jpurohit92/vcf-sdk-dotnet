# Vcenter.ViJson.OpenApi.Model.VsanPerfMetricId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | This is an identification label of a performance metric - VsanPerfMetricId (i.e., &#39;iopsRead&#39;, &#39;iopsWrite&#39;).  It is unique for a type of monitored entities like VMs, but not unique among different types of entities. For example both VM and disk entities have &#39;iopsRead&#39; metric label. All performance statistics are represented using performance metrics. It is a basic element used in perforamnce stats querying and performance stats presentation. When querying stats of an entity, you can use metric labels to specify what kind of metrics you want in the query spec (see *VsanPerfQuerySpec.labels*). In performance stats query results, metric labels are also used to identify stats data for different metrics (used in VsanPerfMetricId). You can get all supported metrics of an entity using the API of *VsanPerformanceManager.VsanPerfGetSupportedEntityTypes*.  | 
**Group** | **string** | The group label of the performance metric.  i.e., Metric groups include \&quot;domclient\&quot;, \&quot;domowner\&quot;, \&quot;domcompmgr\&quot;.  | [optional] 
**RollupType** | **string** | Unused field.  See also *VsanPerfSummaryType_enum*.  | [optional] 
**StatsType** | **string** | Unused field.  See also *VsanPerfStatsType_enum*.  | [optional] 
**Name** | **string** | The display name of a performance metric  | [optional] 
**Description** | **string** | The description a performance metric  | [optional] 
**MetricsCollectInterval** | **int** | Metrics collect interval value from the vSAN performance configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

