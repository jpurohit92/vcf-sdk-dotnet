# Vcenter.ViJson.OpenApi.Model.SharesInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Shares** | **int** | The number of shares allocated.  Used to determine resource allocation in case of resource contention. This value is only set if level is set to custom. If level is not set to custom, this value is ignored. Therefore, only shares with custom values can be compared.  There is no unit for this value. It is a relative measure based on the settings for other resource pools.  | 
**Level** | **SharesLevelEnum** | The allocation level.  The level is a simplified view of shares. Levels map to a pre-determined set of numeric values for shares. If the shares value does not map to a predefined size, then the level is set as custom.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

