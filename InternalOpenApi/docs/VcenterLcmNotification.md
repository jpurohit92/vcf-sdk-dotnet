# Vcenter.Automation.OpenApi.Model.VcenterLcmNotification
The Vcenter.Lcm.Notification schema describes a notification that can be reported by the appliance task, which can be of type info, warning or errors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The notification id. | 
**Time** | **DateTime** | The time the notification was raised/found.  Only if the time information is available. | [optional] 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The notification message. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The resolution message, if any.  Only set for warnings and errors. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

