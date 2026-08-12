# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryReconciliationJobInfo
The Appliance.Recovery.Reconciliation.Job.Info schema represents the reconciliation job information. It contains information related to current Status, any associated messages and progress as percentage.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of the operation associated with the task.  This property was added in __vSphere API 6.7__. | 
**Service** | **string** | Name of the service containing the operation.  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.reconciliation.job&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.reconciliation.job&#x60;. | 
**Operation** | **string** | Name of the operation associated with the task.  This property was added in __vSphere API 6.7__. | 
**Parent** | **string** | Parent of the current task.  This property was added in __vSphere API 6.7__.  This property will be missing or &#x60;null&#x60; if the task has no parent.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.reconciliation.job&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.recovery.reconciliation.job&#x60;. | [optional] 
**Target** | [**VapiStdDynamicID**](VapiStdDynamicID.md) | Identifier of the target resource the operation modifies.  This property was added in __vSphere API 6.7__.  This property will be missing or &#x60;null&#x60; if the task has multiple targets or no target. | [optional] 
**Status** | **string** | Status of the operation associated with the task.  Possible values:   - &#x60;NONE&#x60;: The operation is not running.   - &#x60;RUNNING&#x60;: The operation is in progress.   - &#x60;SUCCEEDED&#x60;: The operation completed successfully.   - &#x60;FAILED&#x60;: The operation failed.   For more information see: *Appliance.Recovery.Reconciliation.Job.Status*.  This property was added in __vSphere API 6.7__. | 
**Cancelable** | **bool** | Flag to indicate whether or not the operation can be cancelled. The value may change as the operation progresses.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, the operation cannot be canceled. | [optional] 
**Error** | **Object** | Description of the error if the operation status is \&quot;FAILED\&quot;.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the description of why the operation failed will be included in the result of the operation (see Info#result). | [optional] 
**StartTime** | **DateTime** | Time when the operation is started.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of status is one of *Appliance.Recovery.Reconciliation.Job.Status.RUNNING*, *Appliance.Recovery.Reconciliation.Job.Status.SUCCEEDED*, or *Appliance.Recovery.Reconciliation.Job.Status.FAILED*. | [optional] 
**EndTime** | **DateTime** | Time when the operation is completed.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of status is one of *Appliance.Recovery.Reconciliation.Job.Status.SUCCEEDED* or *Appliance.Recovery.Reconciliation.Job.Status.FAILED*. | [optional] 
**Messages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | A list of localized messages.  This property was added in __vSphere API 6.7__. | 
**Progress** | **long** | The progress of the job as a percentage.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

