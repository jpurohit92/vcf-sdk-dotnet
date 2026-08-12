# Vcenter.Automation.OpenApi.Model.VcenterDeploymentNotifications
The Vcenter.Deployment.Notifications schema contains info/warning/error messages that can be reported be the task.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Info** | [**List&lt;VcenterDeploymentNotification&gt;**](VcenterDeploymentNotification.md) | Info notification messages reported.  This property was added in __vSphere API 6.7__.  Only set if an info was reported by the task. | [optional] 
**Warnings** | [**List&lt;VcenterDeploymentNotification&gt;**](VcenterDeploymentNotification.md) | Warning notification messages reported.  This property was added in __vSphere API 6.7__.  Only set if an warning was reported by the task. | [optional] 
**Errors** | [**List&lt;VcenterDeploymentNotification&gt;**](VcenterDeploymentNotification.md) | Error notification messages reported.  This property was added in __vSphere API 6.7__.  Only set if an error was reported by the task. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

