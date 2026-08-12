# Vcenter.ViJson.OpenApi.Model.MetricAlarmExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operator** | **MetricAlarmOperatorEnum** | The operation to be tested on the metric.  | 
**Type** | **string** | Name of the object type containing the property.  | 
**Metric** | [**PerfMetricId**](PerfMetricId.md) | The instance of the metric.  | 
**Yellow** | **int** | Whether or not to test for a yellow condition.  If not set, do not calculate yellow status. If set, it contains the threshold value that triggers yellow status.  | [optional] 
**YellowInterval** | **int** | Time interval in seconds for which the yellow condition must be true before the yellow status is triggered.  If unset, the yellow status is triggered immediately when the yellow condition becomes true.  | [optional] 
**Red** | **int** | Whether or not to test for a red condition.  If not set, do not calculate red status. If set, it contains the threshold value that triggers red status.  | [optional] 
**RedInterval** | **int** | Time interval in seconds for which the red condition must be true before the red status is triggered.  If unset, the red status is triggered immediately when the red condition becomes true.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

