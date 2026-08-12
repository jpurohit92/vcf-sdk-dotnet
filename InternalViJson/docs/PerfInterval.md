# Vcenter.ViJson.OpenApi.Model.PerfInterval

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A unique identifier for the interval.  | 
**SamplingPeriod** | **int** | Number of seconds that data is sampled for this interval.  The real-time samplingPeriod is 20 seconds.  | 
**Name** | **string** | The name of the historical interval.  A localized string that provides a name for the interval. Names include: - \&quot;Past Day\&quot; - \&quot;Past Week\&quot; - \&quot;Past Month\&quot; - \&quot;Past Year\&quot;    The name is not meaningful in terms of system behavior. That is, the interval named &amp;#147;Past Week&amp;#148; works as it does because of its length, level, and so on, not because of the value of this string.  | 
**Length** | **int** | Number of seconds that the statistics corresponding to this interval are kept on the system.  | 
**Level** | **int** | Statistics collection level for this historical interval.  vCenter Server will aggregate only those statistics that match the value of this property for this historical interval. For ESX, the value of this property is null. For vCenter Server, the value will be a number from 1 to 4.  | [optional] 
**Enabled** | **bool** | Indicates whether the interval is enabled (true) or disabled (false).  Disabling a historical interval prevents vCenter Server from collecting metrics for that interval and all higher (longer) intervals.  For example, disabling the \&quot;Past Month\&quot; interval disables both \&quot;Past Month\&quot; and \&quot;Past Year\&quot; intervals. The system will aggregate and retain performance data using the \&quot;Past Day\&quot; and \&quot;Past Week\&quot; intervals only.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

