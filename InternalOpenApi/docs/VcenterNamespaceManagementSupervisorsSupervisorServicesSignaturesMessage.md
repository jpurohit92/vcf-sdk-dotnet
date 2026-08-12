# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesMessage
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Message schema contains information related to Supervisor Service signature validation.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | The severity level of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message.   - &#x60;WARNING&#x60;: Message indicates a warning.   - &#x60;ERROR&#x60;: Message indicates an error.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Message.Severity*.  This property was added in __vSphere API 9.1.0.0__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Additional details about the message.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no additional details are provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

