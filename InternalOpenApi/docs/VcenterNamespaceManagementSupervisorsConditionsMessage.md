# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsConditionsMessage
The Vcenter.NamespaceManagement.Supervisors.Conditions.Message schema contains user-readable information related to a Vcenter.NamespaceManagement.Supervisors.Conditions.Condition.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message.   - &#x60;WARNING&#x60;: Warning message.   - &#x60;ERROR&#x60;: Error message.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Conditions.Severity*.  This property was added in __vSphere API 8.0.0.1__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the message.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, message details are not required for taking actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

