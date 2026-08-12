# Vcenter.ViJson.OpenApi.Model.StorageIORMConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether or not the service is enabled.  | [optional] 
**CongestionThresholdMode** | **string** | Mode of congestion threshold specification For more information, see *StorageIORMThresholdMode_enum*  | [optional] 
**CongestionThreshold** | **int** | The latency beyond which the storage array is considered congested.  For more information, see *StorageIORMInfo.congestionThreshold*  | [optional] 
**PercentOfPeakThroughput** | **int** | The percentage of peak throughput to be used for setting threshold latency of a datastore.  Valid values are between 50 to 100.  For more information, see *StorageIORMInfo.congestionThreshold*  | [optional] 
**StatsCollectionEnabled** | **bool** | Flag indicating whether the service is enabled in stats collection mode.  | [optional] 
**ReservationEnabled** | **bool** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Flag indicating whether IO reservations support is enabled.  | [optional] 
**StatsAggregationDisabled** | **bool** | Flag indicating whether stats aggregation is disabled.  | [optional] 
**ReservableIopsThreshold** | **int** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Storage DRS makes storage migration recommendations if total IOPs reservation for all VMs running on the datastore is higher than specified threshold value.  This value (if present) overrides *StorageIORMInfo.reservableIopsThreshold*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

