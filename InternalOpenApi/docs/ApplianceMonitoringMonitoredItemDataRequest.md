# Vcenter.Automation.OpenApi.Model.ApplianceMonitoringMonitoredItemDataRequest
Appliance.Monitoring.MonitoredItemDataRequest schema Structure representing requested monitored item data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interval** | **string** | interval between values in hours, minutes  Possible values:   - &#x60;MINUTES30&#x60;: Thirty minutes interval between values. One week is 336 values.   - &#x60;HOURS2&#x60;: Two hours interval between values. One month has 360 values.   - &#x60;MINUTES5&#x60;: Five minutes interval between values (finest). One day would have 288 values, one week is 2016.   - &#x60;DAY1&#x60;: 24 hours interval between values. One year has 365 values.   - &#x60;HOURS6&#x60;: Six hour interval between values. One quarter is 360 values.   For more information see: *Appliance.Monitoring.IntervalType*. | 
**Function** | **string** | aggregation function  Possible values:   - &#x60;COUNT&#x60;: Aggregation takes count per period (sum)   - &#x60;MAX&#x60;: Aggregation takes maximums per period   - &#x60;AVG&#x60;: Aggregation takes average per period   - &#x60;MIN&#x60;: Aggregation takes minimums per period   For more information see: *Appliance.Monitoring.FunctionType*. | 
**StartTime** | **DateTime** | Start time in UTC | 
**EndTime** | **DateTime** | End time in UTC | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

