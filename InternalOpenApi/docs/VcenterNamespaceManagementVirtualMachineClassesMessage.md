# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementVirtualMachineClassesMessage
The Vcenter.NamespaceManagement.VirtualMachineClasses.Message schema contains the information about the object configuration.  This schema was added in __vSphere API 7.0.2.00100__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message. This may be accompanied by vCenter event.   - &#x60;WARNING&#x60;: Warning message. This may be accompanied by vCenter event.   - &#x60;ERROR&#x60;: Error message. This is accompanied by vCenter event and/or alarm.   For more information see: *Vcenter.NamespaceManagement.VirtualMachineClasses.Message.MessageSeverity*.  This property was added in __vSphere API 7.0.2.00100__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the message.  This property was added in __vSphere API 7.0.2.00100__.  If missing or &#x60;null&#x60;, message details are not required for taking actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

