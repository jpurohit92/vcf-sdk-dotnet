# Vcenter.ViJson.OpenApi.Model.PerfCounterInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A system-generated number that uniquely identifies the counter in the context of the system.  The performance counter ID.  | 
**NameInfo** | [**ElementDescription**](ElementDescription.md) | The name of the counter with label and summary details.  For example, the counter with name \&quot;usage\&quot; for the \&quot;cpu\&quot; group of performance counters.  | 
**GroupInfo** | [**ElementDescription**](ElementDescription.md) | The group of the performance counter with its label and summary details.  Counter groups include \&quot;cpu,\&quot; \&quot;mem,\&quot; \&quot;net,\&quot; \&quot;disk,\&quot; \&quot;system,\&quot; \&quot;rescpu,\&quot; and \&quot;clusterServices,\&quot; for example.  | 
**UnitInfo** | [**ElementDescription**](ElementDescription.md) | The unit for the values of the performance counter with its label and summary details.  See *PerformanceManagerUnit_enum* for a description of the valid values.  | 
**RollupType** | **PerfSummaryTypeEnum** | The counter type.  Valid values include average, maximum, minimum, latest, summation, or none. This determines the type of statistical values that are returned for the counter. None means that the counter is never rolled up.  | 
**StatsType** | **PerfStatsTypeEnum** | Statistics type for the counter.  Valid values include absolute, delta, or rate.  | 
**Level** | **int** | Minimum level at which metrics of this type will be collected by VirtualCenter Server.  The value for this property for any performance counter is a number from 1 to 4. The higher the setting, the more data is collected by VirtualCenter Server. The default setting for VirtualCenter Server is 1, which collects the minimal amount of performance data that is typically useful to administrators and developers alike. The specific level of each counter is documented in the respective counter-documentation pages, by group. See *PerformanceManager* for links to the counter group pages.  | [optional] 
**PerDeviceLevel** | **int** | Minimum level at which the per device metrics of this type will be collected by vCenter Server.  The value for this property for any performance counter is a number from 1 to 4. By default all per device metrics are calculated at level 3 or more. If a certain per device counter is collected at a certain level, the aggregate metric is also calculated at that level, i.e., perDeviceLevel is greater than or equal to level.  | [optional] 
**AssociatedCounterId** | **List&lt;int&gt;** | Deprecated as of VI API 2.5, this property is not used.  The counter IDs associated with the same performance counter name for the same device type.  For example, the rollup types for CPU Usage for a host are average, minimum, and maximum&amp;#46; Therefore, their counter IDs are associated.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

