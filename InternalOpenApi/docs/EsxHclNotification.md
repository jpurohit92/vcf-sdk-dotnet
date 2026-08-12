# Vcenter.Automation.OpenApi.Model.EsxHclNotification
The Esx.Hcl.Notification schema contains properties to describe any info/warning/error messages that Tasks can raise.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The notification id. | 
**Time** | **DateTime** | The time the notification was raised/found. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The notification message. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The resolution message, if any.  Only set if there is a resolution available for this notification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

