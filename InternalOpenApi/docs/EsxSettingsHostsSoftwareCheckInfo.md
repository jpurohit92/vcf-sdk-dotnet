# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareCheckInfo
The Esx.Settings.Hosts.Software.CheckInfo schema contains properties that describe a particular check.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | **string** | The check identifier.  This property was added in __vSphere API 8.0.0.1__. | 
**Name** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The check name.  This property was added in __vSphere API 8.0.0.1__. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Human-readable check description.  This property was added in __vSphere API 8.0.0.1__. | 
**Originator** | **string** | The service that performed the check.  This property was added in __vSphere API 8.0.0.1__.  Only set if there is an originator available for this check. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

