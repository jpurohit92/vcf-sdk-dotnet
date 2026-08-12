# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeStatusTask
The Vcenter.Lcm.Deployment.MigrationUpgrade.Status.Task schema contains properties to describe a particular deployment task.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Progress** | [**CisTaskProgress**](CisTaskProgress.md) | The progress info of this deployment task.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of CommonInfo#status is one of *Vcenter.Lcm.Deployment.Common.Status.RUNNING*, *Vcenter.Lcm.Deployment.Common.Status.BLOCKED*, *Vcenter.Lcm.Deployment.Common.Status.SUCCEEDED*, *Vcenter.Lcm.Deployment.Common.Status.FAILED*, or *Vcenter.Lcm.Deployment.Common.Status.CANCELED*. | [optional] 
**Notifications** | [**VcenterLcmNotifications**](VcenterLcmNotifications.md) | Result of the task.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if result is not available at the current step of the task. | [optional] 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of the operation associated with the task.  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | Status of the operation associated with the task.  Possible values:   - &#x60;PENDING&#x60;: The operation is in pending state.   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;BLOCKED&#x60;: The operation is blocked.   - &#x60;SUCCEEDED&#x60;: The operation completed successfully.   - &#x60;FAILED&#x60;: The operation failed.   - &#x60;CANCELED&#x60;: The operation was canceled.   For more information see: *Vcenter.Lcm.Deployment.Common.Status*.  This property was added in __vSphere API 9.0.0.0__. | 
**Cancelable** | **bool** | Flag to indicate whether or not the operation can be cancelled. The value may change as the operation progresses.  This property was added in __vSphere API 9.0.0.0__. | 
**Error** | **Object** | Description of the error if the operation status is \&quot;FAILED\&quot; or the upgrade has been canceled.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; there is no error raised by the upgrade | [optional] 
**StartTime** | **DateTime** | Time when the operation is started.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of status is one of *Vcenter.Lcm.Deployment.Common.Status.RUNNING*, *Vcenter.Lcm.Deployment.Common.Status.BLOCKED*, *Vcenter.Lcm.Deployment.Common.Status.SUCCEEDED*, *Vcenter.Lcm.Deployment.Common.Status.FAILED*, or *Vcenter.Lcm.Deployment.Common.Status.CANCELED*. | [optional] 
**EndTime** | **DateTime** | Time when the operation is completed.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of status is one of *Vcenter.Lcm.Deployment.Common.Status.SUCCEEDED*, *Vcenter.Lcm.Deployment.Common.Status.FAILED*, or *Vcenter.Lcm.Deployment.Common.Status.CANCELED*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

