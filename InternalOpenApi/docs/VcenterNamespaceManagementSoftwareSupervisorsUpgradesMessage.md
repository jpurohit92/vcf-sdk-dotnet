# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesMessage
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.Message schema contains the information about the object configuration.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | Type of the message.  Possible values:   - &#x60;INFO&#x60;: Informational message. This may be accompanied by vCenter event.   - &#x60;WARNING&#x60;: Warning message. This may be accompanied by vCenter event.   - &#x60;ERROR&#x60;: Error message. This is accompanied by vCenter event and/or alarm.   For more information see: *Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.Message.Severity*.  This property was added in __vSphere API 9.1.0.0__. | 
**Details** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Details about the message.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

