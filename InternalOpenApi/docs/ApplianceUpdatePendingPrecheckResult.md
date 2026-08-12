# Vcenter.Automation.OpenApi.Model.ApplianceUpdatePendingPrecheckResult
The Appliance.Update.Pending.PrecheckResult schema contains estimates of how long it will take install and rollback an update as well as a list of possible warnings and problems with installing the update.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckTime** | **DateTime** | Time when this precheck was run  This property was added in __vSphere API 6.7__. | 
**EstimatedTimeToInstall** | **long** | Rough estimate of time to install the update (minutes).  This property was added in __vSphere API 6.7__.  estimatedTimeToInstall If missing or &#x60;null&#x60; N/A | [optional] 
**EstimatedTimeToRollback** | **long** | Rough estimate of time to rollback the update (minutes).  This property was added in __vSphere API 6.7__.  estimatedTimeToRollback If missing or &#x60;null&#x60; N/A | [optional] 
**RebootRequired** | **bool** | Is reboot required to install the update.  This property was added in __vSphere API 6.7__. | 
**Issues** | [**ApplianceNotifications**](ApplianceNotifications.md) | Lists of the issues and warnings  This property was added in __vSphere API 6.7__.  issues If missing or &#x60;null&#x60; N/A | [optional] 
**Questions** | [**List&lt;ApplianceUpdatePendingQuestion&gt;**](ApplianceUpdatePendingQuestion.md) | List of questions that must be answered to install the update.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

