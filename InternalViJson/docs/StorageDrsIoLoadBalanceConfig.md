# Vcenter.ViJson.OpenApi.Model.StorageDrsIoLoadBalanceConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReservablePercentThreshold** | **int** | Storage DRS makes storage migration recommendations if total IOPs reservation of all VMs running on a datastore is higher than the specified threshold.  Storage DRS recommends migration out of all such datastores, if more than one datastore exceed their reserved IOPs threshold.  The actual Iops used to determine threshold are computed from Storage DRS estimation of IOPs capacity of a datastore. The absolute value may change over time, according to storage response to workloads.  The valid values are in the range of 30 (i.e., 30%) to 100 (i.e., 100%). If not specified, the default value is 60%.  | [optional] 
**ReservableIopsThreshold** | **int** | Storage DRS makes storage migration recommendations if total IOPs reservation of all VMs running on a datastore is higher than the specified threshold.  Storage DRS recommends migration out of all such datastores, if more than one datastore exceed their reserved IOPs threshold.  This is an advanced option, and should only be used if Storage DRS estimated IOPs capacity is incorrect for datastores. The value should be based on conservative estimate of storage performance, and ideally should be set to about 50-60% of worse case peak performance of backing LUN.  | [optional] 
**ReservableThresholdMode** | **string** | Determines which reservation threshold specification to use.  See *StorageDrsPodConfigInfoBehavior_enum*. If unspecified, the mode is assumed automatic by default. Storage DRS uses percentage value in that case. If mode is specified, but corresponding reservationThreshold value is absent, option specific defaults are used.  | [optional] 
**IoLatencyThreshold** | **int** | Storage DRS makes storage migration recommendations if I/O latency on one (or more) of the datastores is higher than the specified threshold.  Unit: millisecond. The valid values are in the range of 5 to 100. If not specified, the default value is 15.  | [optional] 
**IoLoadImbalanceThreshold** | **int** | Storage DRS makes storage migration recommendations if I/O load imbalance level is higher than the specified threshold.  Unit: a number. The valid values are in the range of 1 to 100. If not specified, the default value is 5.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

