# Vcenter.ViJson.OpenApi.Model.VsanStartProactiveRebalanceRequestType
The parameters of *HostVsanHealthSystem.VsanStartProactiveRebalance*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeSpan** | **int** | Determines how long this proactive rebalance operation lasts in seconds, default 86400.  | [optional] 
**VarianceThreshold** | **float** | Only if the disk&#39;s fullness (defined as used\\_capacity/disk\\_capacity) is above mean fullness and exceeds the lowest-usage disk in the cluster than this threshold, this disk is qualified for proactive rebalancing, default 0.3.  | [optional] 
**TimeThreshold** | **int** | Only if the variance threshold has been continuously exceeded for this amount of time (in sec), the proactive rebalance operation will be applied to this disk, default 1800.  | [optional] 
**RateThreshold** | **int** | Determines how many bytes CLOMD on this node can move out per hour (MB/hr) for proactive rebalancing, default 51200.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

