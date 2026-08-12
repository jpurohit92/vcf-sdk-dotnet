# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSummaryMessage
The Vcenter.NamespaceManagement.Supervisors.Summary.Message schema contains the information about supervisor errors/warnings.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the message.  This property was added in __vSphere API 9.1.0.0__. | 
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message.   - &#x60;WARNING&#x60;: Warning message.   - &#x60;ERROR&#x60;: Error message.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Summary.Message.Severity*.  This property was added in __vSphere API 9.1.0.0__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Contains details about the message.  This property was added in __vSphere API 9.1.0.0__. | 
**KbArticleLink** | **string** | Optional link to a KB article providing more details about the message.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60; there is not KB article associated with the message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

