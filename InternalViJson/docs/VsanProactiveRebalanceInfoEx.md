# Vcenter.ViJson.OpenApi.Model.VsanProactiveRebalanceInfoEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Running** | **bool** | True indicates the proactive rebalance is running on the host  | [optional] 
**StartTs** | **DateTime** | The proactive rebalance starting time on the host  | [optional] 
**StopTs** | **DateTime** | The proactive rebalance stop time on the host  | [optional] 
**VarianceThreshold** | **float** | Percentage points that are allowed above the lowest fullness of any disk.  Any disk with a variance higher than this threshold is considered too loaded from a balance perspective.  | [optional] 
**TimeThreshold** | **int** | The threshold to enable proactive rebalance action.  Only if the variance threshold has been continuously exceeded for this amount of time (in sec), the proactive rebalance operation action will be enabled which can be triggered by vSphere/storage admin. Default is 1800 second.  | [optional] 
**RateThreshold** | **int** | varianceThreshold Only if the disk&#39;s fullness (defined as used\\_capacity/disk\\_capacity) is above mean fullness and exceeds the lowest-usage disk in the cluster than this threshold, this disk is qualified for proactive rebalancing, default 0.3  | [optional] 
**Hostname** | **string** | Name of vSAN host  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | Only set when an error occurred in retrieving the rebalance information.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

