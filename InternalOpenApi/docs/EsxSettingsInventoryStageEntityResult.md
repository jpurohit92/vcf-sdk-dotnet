# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryStageEntityResult
The Esx.Settings.Inventory.StageEntityResult schema contains the operation status and notifications.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the operation on this entity.  Possible values:   - &#x60;IN_PROGRESS&#x60;: The operation is in progress.   - &#x60;COMPLETED&#x60;: The operation completed successfully.   - &#x60;FAILED&#x60;: The operation encountered an unspecified error.   For more information see: *Esx.Settings.Inventory.StageStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications providing additional information for the operation on this entity.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60;, there is no notifications. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

