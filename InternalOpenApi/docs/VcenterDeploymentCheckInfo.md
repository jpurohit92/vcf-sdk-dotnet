# Vcenter.Automation.OpenApi.Model.VcenterDeploymentCheckInfo
The Vcenter.Deployment.CheckInfo schema describes the result of the appliance deployment check.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of the check.  Possible values:   - &#x60;SUCCESS&#x60;: All checks have completed successfully.   - &#x60;FAILED&#x60;: A fatal error was encountered when running the sanity checks.   For more information see: *Vcenter.Deployment.CheckStatus*.  This property was added in __vSphere API 6.7__. | 
**Result** | [**VcenterDeploymentNotifications**](VcenterDeploymentNotifications.md) | Result of the check.  This property was added in __vSphere API 6.7__.  This property will be missing or &#x60;null&#x60; if result is not available at the current step of the task. | [optional] 
**SourceInfo** | [**VcenterDeploymentSourceInfo**](VcenterDeploymentSourceInfo.md) | Information collected from the source machine.  This property was added in __vSphere API 7.0.0.0__.  This property is used only for upgrade. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

