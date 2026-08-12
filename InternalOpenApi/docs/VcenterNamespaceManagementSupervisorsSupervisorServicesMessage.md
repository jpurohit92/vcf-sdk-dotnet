# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesMessage
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Message schema contains information about the Supervisor Service on a Supervisor, and can include details about compatibility, Service status, and more.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Severity of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message. This may be accompanied by vCenter event.   - &#x60;WARNING&#x60;: Warning message. This may be accompanied by vCenter event.   - &#x60;ERROR&#x60;: Error message. This is accompanied by vCenter event and/or alarm.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Message.MessageSeverity*.  This property was added in __vSphere API 8.0.3.0__. | 
**Type** | **string** | Type of the message.  Possible values:   - &#x60;COMPATIBILITY&#x60;: Message contains the results of a compatibility check between the service and the Supervisor.   - &#x60;SIGNATURE&#x60;: Message contains details related to signature verification of the service artifacts.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Message.MessageType*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the message type is not specified. | [optional] 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the message.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, message details are not required for taking actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

