# Vcenter.ViJson.OpenApi.Model.LifecyclePreCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The check type.  Check *VimVsanLifecyclePreCheckType_enum* for all possible types.  See also *VimVsanLifecyclePreCheckType_enum*.  | [optional] 
**Description** | [**LocalizableMessage**](LocalizableMessage.md) | The description of the lifecycle check.  | [optional] 
**Status** | **string** | The status of the lifecycle check: green, yellow or red.  See also *VsanHealthStatusType_enum*.  | 
**Reason** | [**LocalizableMessage**](LocalizableMessage.md) | The reason why the lifecycle check returned an unsuccessful result.  It contains the error/warning message of the lifecycle check.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

