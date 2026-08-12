# Vcenter.Automation.OpenApi.Model.EsxHostsNotification
The Esx.Hosts.Notification schema contains properties to describe any info/warning/error messages that Tasks can raise.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The notification id.  This property was added in __vSphere API 7.0.2.0__. | 
**Time** | **DateTime** | The time the notification was raised/found.  This property was added in __vSphere API 7.0.2.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The notification message.  This property was added in __vSphere API 7.0.2.0__. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The resolution message, if any.  This property was added in __vSphere API 7.0.2.0__.  Only set if there is a resolution available for this notification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

