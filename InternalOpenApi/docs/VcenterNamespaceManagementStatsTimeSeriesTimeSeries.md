# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementStatsTimeSeriesTimeSeries
A set of timestamps and statistical values representing a time series. The lengths of *Vcenter.NamespaceManagement.Stats.TimeSeries.TimeSeries.time_stamps* and *Vcenter.NamespaceManagement.Stats.TimeSeries.TimeSeries.values* will always match each other.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Counter** | **string** | Counter identifier.  This property was added in __vSphere API 7.0.0.0__. | 
**TimeStamps** | **List&lt;long&gt;** | Sequence of UNIX timestamp values at which statistical values were sampled. https://en.wikipedia.org/wiki/Unix_time  This property was added in __vSphere API 7.0.0.0__. | 
**Values** | **List&lt;long&gt;** | Sequence of sampled values corresponding to the timestamps in tss.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

