# Vcenter.Automation.OpenApi.Model.ApplianceNotifications
The Appliance.Notifications schema contains info/warning/error messages that can be reported be the appliance task.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Info** | [**List&lt;ApplianceNotification&gt;**](ApplianceNotification.md) | Info notification messages reported.  This property was added in __vSphere API 6.7__.  Only set if an info was reported by the appliance task. | [optional] 
**Warnings** | [**List&lt;ApplianceNotification&gt;**](ApplianceNotification.md) | Warning notification messages reported.  This property was added in __vSphere API 6.7__.  Only set if an warning was reported by the appliance task. | [optional] 
**Errors** | [**List&lt;ApplianceNotification&gt;**](ApplianceNotification.md) | Error notification messages reported.  This property was added in __vSphere API 6.7__.  Only set if an error was reported by the appliance task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

