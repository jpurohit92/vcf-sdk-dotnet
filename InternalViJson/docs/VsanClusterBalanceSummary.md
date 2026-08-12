# Vcenter.ViJson.OpenApi.Model.VsanClusterBalanceSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarianceThreshold** | **long** | Percentage points that are allowed above the lowest fullness of any disk.  Any disk with a variance higher than this threshold is considered too loaded from a balance perspective.  | 
**Disks** | [**List&lt;VsanClusterBalancePerDiskInfo&gt;**](VsanClusterBalancePerDiskInfo.md) | List of all healthy capacity disks in the cluster with their detailed balance evaluation.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

