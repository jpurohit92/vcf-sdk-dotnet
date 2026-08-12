# Vcenter.Automation.OpenApi.Model.EsxSettingsNotification
The Esx.Settings.Notification schema contains properties to describe any info/warning/error messages that Tasks can raise.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the notification.  Possible values:   - &#x60;INFO&#x60;   - &#x60;WARNING&#x60;   - &#x60;ERROR&#x60;   For more information see: *Esx.Settings.Notification.Type*.  This property was added in __vSphere API 7.0.2.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Id** | **string** | The notification id.  This property was added in __vSphere API 7.0.0.0__. | 
**Time** | **DateTime** | The time the notification was raised/found.  This property was added in __vSphere API 7.0.0.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The notification message.  This property was added in __vSphere API 7.0.0.0__. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The resolution message, if any.  This property was added in __vSphere API 7.0.0.0__.  Only set if there is a resolution available for this notification. | [optional] 
**Originator** | **string** | The originator of the notification.  This property was added in __vSphere API 7.0.2.0__.  Only set if there is an originator available for this notification. | [optional] 
**Retriable** | **bool** | Indicates whether the error is retriable.  This property was added in __vSphere API 7.0.2.0__.  Only set for the notification when a retriable error was reported by the task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

