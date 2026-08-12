# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareCheckInfo
The Esx.Settings.Clusters.Software.CheckInfo schema contains properties that describe a particular check.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Check** | **string** | The check identifier.  This property was added in __vSphere API 7.0.0.0__. | 
**Name** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The check name.  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Human-readable check description.  This property was added in __vSphere API 7.0.0.0__. | 
**Originator** | **string** | The service that performed the check.  This property was added in __vSphere API 7.0.2.0__.  Only set if there is an originator available for this check. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

