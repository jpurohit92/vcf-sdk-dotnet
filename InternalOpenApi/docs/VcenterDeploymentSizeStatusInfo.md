# Vcenter.Automation.OpenApi.Model.VcenterDeploymentSizeStatusInfo
The Vcenter.Deployment.Size.Status.Info schema represents information about deployment resize operation  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentState** | **string** | The current state of resize operation.  Possible values:   - &#x60;RESIZING_NOT_STARTED&#x60;: The resizing operation has not yet started   - &#x60;RESIZING_IN_PROGRESS&#x60;: The resizing operation is currently in progress   - &#x60;PENDING_SERVICE_RESTART&#x60;: The resizing operation is waiting for restart of all the vc services   - &#x60;RESIZING_SUCCEEDED&#x60;: The resizing operation has completed successfully   - &#x60;RESIZING_FAILED&#x60;: The resizing operation has failed. It is a permanent failure, when the resizing has failed user needs to start from beginning   For more information see: *Vcenter.Deployment.Size.ResizeState*.  This property was added in __vSphere API 9.1.0.0__. | 
**ResizeInfo** | [**VcenterDeploymentSizeResizeInfo**](VcenterDeploymentSizeResizeInfo.md) | Metadata about resize operation such as source and target deployment size.  This property was added in __vSphere API 9.1.0.0__. | 
**Subtasks** | [**Dictionary&lt;string, VcenterDeploymentSizeTask&gt;**](VcenterDeploymentSizeTask.md) | The map of the resize subtasks and their status information. Possible keys are precheck,reconfigure,disk_auto_grow,service_restart  This property was added in __vSphere API 9.1.0.0__. | 
**StartTime** | **DateTime** | Time when the operation started  This property was added in __vSphere API 9.1.0.0__.  This property will be missing or &#x60;null&#x60; if there is no resize operation | [optional] 
**EndTime** | **DateTime** | Time when the operation is completed.  This property was added in __vSphere API 9.1.0.0__.  This property will be missing or &#x60;null&#x60; if the status is not RESIZING_SUCCEEDED or RESIZING_FAILED. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

