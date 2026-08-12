# Vcenter.ViJson.OpenApi.Model.VsanDiskRebalanceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Indicates the status of rebalancing operation for a disk.  If we failed to find any components that can be moved (due to policy or space issues or object health issues), the status will reflect that status.  See also *VsanDiskBalanceState_enum*.  | 
**BytesMoving** | **long** | Bytes moving for this rebalancing operation.  | [optional] 
**RemainingBytesToMove** | **long** | Remaining bytes needed to move for this rebalancing operation.  | [optional] 
**DiskUsage** | **float** | Percentage disk capacity used.  | [optional] 
**MaxDiskUsage** | **float** | Percentage maximum disk capacity used.  | [optional] 
**MinDiskUsage** | **float** | Percentage minimum disk capacity used.  | [optional] 
**AvgDiskUsage** | **float** | Percentage average disk capacity used.  | [optional] 
**DiskCompUsage** | **float** | Percentage disk component used.  ***Since:*** 8.0.0.4  | [optional] 
**MaxDiskCompUsage** | **float** | Percentage maximum disk component used.  ***Since:*** 8.0.0.4  | [optional] 
**MinDiskCompUsage** | **float** | Percentage minimum disk component used.  ***Since:*** 8.0.0.4  | [optional] 
**AvgDiskCompUsage** | **float** | Percentage average disk component used.  ***Since:*** 8.0.0.4  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

