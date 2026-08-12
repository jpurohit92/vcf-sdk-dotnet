# Vcenter.ViJson.OpenApi.Model.StorageIORMInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether or not the service is enabled.  | 
**CongestionThresholdMode** | **string** | Mode of congestion threshold specification For more information, see *StorageIORMThresholdMode_enum*  | 
**CongestionThreshold** | **int** | The latency beyond which the storage array is considered congested.  If storage I/O resource management is enabled on a datastore, the algorithm tries to maintain the latency to be below or close to this value. The unit is millisecond. The range of this value is between 5 to 100 milliseconds.  | 
**PercentOfPeakThroughput** | **int** | The percentage of peak throughput to be used for setting congestion threshold of a datastore.  Valid values are between 50 to 100. Default value is 90%  For more information, see *StorageIORMInfo.congestionThreshold*  | [optional] 
**StatsCollectionEnabled** | **bool** | Deprecated as of vSphere API 6.5, use *StorageIORMInfo.enabled* instead.  Flag indicating whether service is running in stats collection mode.  | 
**ReservationEnabled** | **bool** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Flag indicating whether IO reservations support is enabled.  | 
**StatsAggregationDisabled** | **bool** | Flag indicating whether stats aggregation is disabled.  | [optional] 
**ReservableIopsThreshold** | **int** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Storage DRS makes storage migration recommendations if total IOPs reservation for all VMs running on the datastore is higher than specified threshold value.  This value (if present) overrides *StorageIORMInfo.reservableIopsThreshold*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

