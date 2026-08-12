# Vcenter.ViJson.OpenApi.Model.QueryAvailablePerfMetricRequestType
The parameters of *PerformanceManager.QueryAvailablePerfMetric*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *managed object* that provides performance metrics.  | 
**BeginTime** | **DateTime** | Starting time (server time) for a period of time from which to return available metrics. If not specified, defaults to oldest available metric for the specified entity.  | [optional] 
**EndTime** | **DateTime** | Ending time (server time) for a period of time from which to return available performance metrics. If not specified, defaults to the most recently generated metric for the specified entity.  | [optional] 
**IntervalId** | **int** | Period of time from which to retrieve metrics, defined by intervalId (rather than beginTime or endTime). Valid intervalIds include: - For real-time counters, the *refreshRate* of   the *performance   provider*. - For historical counters, the *samplingPeriod* of the *historical interval*.     If this parameter is not specified, the system returns available metrics for historical statistics&amp;#46;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

