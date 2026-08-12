# Vcenter.ViJson.OpenApi.Model.QueryPerfCompositeRequestType
The parameters of *PerformanceManager.QueryPerfComposite*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuerySpec** | [**PerfQuerySpec**](PerfQuerySpec.md) | A *PerfQuerySpec* object specifying the query parameters. This *PerfQuerySpec* object specifies a managed object for which composite statistics should be retrieved, with specific optional criteria for filtering the results.  This *PerfQuerySpec* requires a valid *PerfQuerySpec.metricId* property that specifies a metric that is available, in common, to the entity and its children. If the specified metricId is not available to the entity and its children, it is ignored.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

