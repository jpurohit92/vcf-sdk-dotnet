# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLifecycleContentLibrariesMessage
The Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.Message schema contains the information about the Content Library configuration with vSphere Namespaces.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message. This may be accompanied by vCenter event.   - &#x60;WARNING&#x60;: Warning message. This may be accompanied by vCenter event.   - &#x60;ERROR&#x60;: Error message. This is accompanied by vCenter event and/or alarm.   For more information see: *Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.Message.Severity*.  This property was added in __vSphere API 9.0.0.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the message.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

