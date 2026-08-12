# Vcenter.ViJson.OpenApi.Model.UpdateCounterLevelMappingRequestType
The parameters of *PerformanceManager.UpdateCounterLevelMapping*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CounterLevelMap** | [**List&lt;PerformanceManagerCounterLevelMapping&gt;**](PerformanceManagerCounterLevelMapping.md) | An array of *PerformanceManagerCounterLevelMapping* objects. The levels for the counters passed in are changed to the passed in values. If the optional aggregateLevel field is left unset then only the perDeviceLevel is configured. If the optional perDeviceLevel is left unset then only the aggregateLevel is configured. If there are multiple entries in the passed in array for the same counterId being updated then the last entry containing the counterId takes effect.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

