# Vcenter.ViJson.OpenApi.Model.VsanClusterBalancePerDiskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The UUID of the vSAN disk.  | [optional] 
**Fullness** | **long** | Usage level in percent.  | 
**Variance** | **long** | Usage percentage points above the lowest fullness.  If lowest fullness is 10, and this disk has 80, then the variance will be 80 - 10 &#x3D; 70.  | 
**FullnessAboveThreshold** | **long** | Usage percentage points above the acceptable fullness.  Acceptable fullness is a margin of percentage points above the lowest fullness.  | 
**DataToMoveB** | **long** | Amount of data to move to restore balance.  | 
**CompFullness** | **long** | Component usage level in percent.  ***Since:*** 8.0.0.4  | [optional] 
**CompVariance** | **long** | Usage percentage points above the lowest component fullness.  If lowest component fullness is 10, and this disk has 80, then the variance will be 80 - 10 &#x3D; 70.  ***Since:*** 8.0.0.4  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

