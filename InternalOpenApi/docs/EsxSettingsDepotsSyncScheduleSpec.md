# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsSyncScheduleSpec
The Esx.Settings.Depots.SyncSchedule.Spec schema defines the information regarding the sync schedule.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether automatic sync is enabled or not  This property was added in __vSphere API 7.0.0.0__. | 
**Schedule** | [**EsxSettingsDepotsSyncScheduleSchedule**](EsxSettingsDepotsSyncScheduleSchedule.md) | The schedule to check for new updates.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; the schedule must be disabled. | [optional] 
**EmailAddresses** | **List&lt;string&gt;** | Email addresses to which the notification will be sent. If empty, no notification is sent.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

