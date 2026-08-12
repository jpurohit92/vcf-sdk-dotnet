# Vcenter.Automation.OpenApi.Model.EsxSettingsInventoryEntityTransitionResult
The Esx.Settings.Inventory.EntityTransitionResult schema contains information of entities specified in *Esx.Settings.Inventory.TransitionSpec* and the status of their transition operation invoked on them.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The Esx.Settings.Inventory.TransitionStatus describes the state of the transition operation invoked on the specified entity. Here the status describes the status of the operation as defined in #Status.  Possible values:   - &#x60;COMPLETED&#x60;: Describes the specified operation is completed successfully.   - &#x60;FAILED&#x60;: Describes the specified operation failed during its execution.   - &#x60;IN_PROGRESS&#x60;: Describes the specified operation is still in-progress.   For more information see: *Esx.Settings.Inventory.TransitionStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications raised during the execution of transition operation invoked on the specified entity.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

