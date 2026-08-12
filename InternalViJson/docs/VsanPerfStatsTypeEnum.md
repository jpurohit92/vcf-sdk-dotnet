# Vcenter.ViJson.OpenApi.Model.VsanPerfStatsTypeEnum
The type of statistical measurement that a metric value represents.  Valid types are:  Possible values: - `absolute`: Represents an actual value, level, or state of the counter.      For example, the capacity metric represents the actual configured size of the specified disk. In other words, number of samples, samplingPeriod, and intervals have no bearing on an absolute metric value. - `delta`: Represents an amount of change for the metric during the sampling period as compared to the previous interval. - `rate`: Represents a value that has been normalized over the sampling period, enabling values for the same counter type to be compared, regardless of interval.      For example, the number of reads per second. - `VsanPerfStatsType_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

