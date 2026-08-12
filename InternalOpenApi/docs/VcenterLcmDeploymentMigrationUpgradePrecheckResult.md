# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradePrecheckResult
The Vcenter.Lcm.Deployment.MigrationUpgrade.PrecheckResult schema describes the result of a single precheck execution.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the precheck  This property was added in __vSphere API 9.1.0.0__. | 
**State** | **string** | *Vcenter.Lcm.Deployment.Common.PrecheckState* PrecheckState of precheck at the time of getting the status.  Possible values:   - &#x60;NOT_EXECUTED&#x60;: Precheck is not executed yet   - &#x60;EXECUTED&#x60;: Precheck is executed   - &#x60;SKIPPED&#x60;: Precheck is skipped   - &#x60;DISABLED&#x60;: Precheck is disabled   For more information see: *Vcenter.Lcm.Deployment.Common.PrecheckState*.  This property was added in __vSphere API 9.1.0.0__. | 
**Notifications** | [**VcenterLcmNotifications**](VcenterLcmNotifications.md) | Notifications - List of Info, Errors and Warnings message encountered while running precheck.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; there was no notification generated while executing precheck. | [optional] 
**Error** | **Object** | Description of the fatal error which occurred during precheck (with id) execution which prevented the precheck process to continue. For example: \&quot;Failed to load a library\&quot; \&quot;Service crash\&quot; etc.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; there was no error that prevented the execution of the checks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

