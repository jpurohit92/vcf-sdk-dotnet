# Vcenter.ViJson.OpenApi.Model.StorageDrsSpaceLoadBalanceConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpaceThresholdMode** | **string** |  | [optional] 
**SpaceUtilizationThreshold** | **int** | Storage DRS makes storage migration recommendations if space utilization on one (or more) of the datastores is higher than the specified threshold.  The valid values are in the range of 50 (i.e., 50%) to 100 (i.e., 100%). If not specified, the default value is 80%.  | [optional] 
**FreeSpaceThresholdGB** | **int** | Storage DRS makes storage migration recommendations if free space on one (or more) of the datastores falls below the specified threshold.  The unit is in gigabytes and the minimum value is 1GB. The maximum value is limited by the capacity of the smallest datastore in a datastore cluster. If not specified, the default value is 50GB.  | [optional] 
**MinSpaceUtilizationDifference** | **int** | Storage DRS considers making storage migration recommendations if the difference in space utilization between the source and destination datastores is higher than the specified threshold.  The valid values are in the range of 1 (i.e., 1%) to 50 (i.e., 50%). If not specified, the default value is 5%.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

