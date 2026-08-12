# Vcenter.Automation.OpenApi.Model.ApplianceNotification
The Appliance.Notification schema describes a notification that can be reported by the appliance task  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The notification id.  This property was added in __vSphere API 6.7__. | 
**Time** | **DateTime** | The time the notification was raised/found.  This property was added in __vSphere API 6.7__.  Only if the time information is available. | [optional] 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The notification message.  This property was added in __vSphere API 6.7__. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The resolution message, if any.  This property was added in __vSphere API 6.7__.  Only set for warnings and errors. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

