# Vcenter.ViJson.OpenApi.Model.VsanVcLifecycleCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The overall status of the lifecycle checks: green) All checks passed yellow) At least one yellow status check, no red status checks red) At least one red status check, yellow status checks also possible  See also *VsanHealthStatusType_enum*.  | 
**PreCheckResults** | [**List&lt;LifecyclePreCheckResult&gt;**](LifecyclePreCheckResult.md) | The list of results for lifecycle checks.  Check *LifecyclePreCheckResult* for details.  | [optional] 
**ConfigDetails** | [**LifecycleConfigDetails**](LifecycleConfigDetails.md) | vSAN cluster configuration details.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

