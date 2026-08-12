# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHealthInfo
The Vcenter.Content.Registries.Health.Info schema contains health information about a container registry.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Container registry status.  Possible values:   - &#x60;STARTING&#x60;: Container registry is starting.   - &#x60;RUNNING&#x60;: Container registry is running.   - &#x60;WARNING&#x60;: Container registry is running with some warning, for example, storage reaches the threshold configuration.   - &#x60;ERROR&#x60;: Container registry failed to start or stopped with fatal error.   - &#x60;DELETING&#x60;: Container registry is being deleted.   For more information see: *Vcenter.Content.Registries.Health.Status*.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the status.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, message details are not required for taking actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

