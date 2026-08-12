# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesMessage
The Vcenter.Namespaces.Instances.Message schema contains the information about the object configuration.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message. This may be accompanied by vCenter event.   - &#x60;WARNING&#x60;: Warning message. This may be accompanied by vCenter event.   - &#x60;ERROR&#x60;: Error message. This is accompanied by vCenter event and/or alarm.   For more information see: *Vcenter.Namespaces.Instances.Message.MessageSeverity*.  This property was added in __vSphere API 7.0.0.0__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the message.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, message details are not required for taking actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

