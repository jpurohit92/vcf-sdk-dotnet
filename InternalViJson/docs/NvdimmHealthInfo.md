# Vcenter.ViJson.OpenApi.Model.NvdimmHealthInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HealthStatus** | **string** | Device health status.  | 
**HealthInformation** | **string** | Health status description.  | 
**StateFlagInfo** | **List&lt;string&gt;** | State flag information.  This information is the cumulation of state flags of all the NVDIMM region state flags. It must be one or more of *NvdimmNvdimmHealthInfoState_enum*  | [optional] 
**DimmTemperature** | **int** | Current Nvdimm temperature in degree Celsius.  | 
**DimmTemperatureThreshold** | **int** | Nvdimm temperature threshold.  Default value is 0, indicating threshold has not reached, if set to 1, reached threshold limit.  | 
**SpareBlocksPercentage** | **int** | Percentage of spare capavity as a percentage of factory configured space (valid range 0 to 100)  | 
**SpareBlockThreshold** | **int** | Spare block threshold.  Default value is 0, indicating threshold has not reached, if set to 1, reached threshold limit.  | 
**DimmLifespanPercentage** | **int** | Lifespan of Nvdimm as percentage.  100% &#x3D; Warranted life span has reached.  | 
**EsTemperature** | **int** | Energy source current temperature in degree Celsius.  Default value is 0, indicating there is no energy source for these nvdimms.  | [optional] 
**EsTemperatureThreshold** | **int** | Energy source temperature threshold.  Default value is 0, indicating threshold has not reached, if set to 1, reached threshold limit.  | [optional] 
**EsLifespanPercentage** | **int** | Lifespan of Energy source as percentage.  100% &#x3D; Warranted life span has reached. Default value is 0, indicating there is no energy source.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

