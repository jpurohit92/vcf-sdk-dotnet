# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareCheckIssue
The Esx.Settings.Hosts.Software.CheckIssue schema contains properties that describe a particular check issue.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of what was the issue containing as much user-relevant context as possible. The user should be able to understand which sub-system failed and why.  This property was added in __vSphere API 8.0.0.1__. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Possible resolution for the issue. This should contain actionable information that the user can use to resolve the issue.  This property was added in __vSphere API 8.0.0.1__.  Can be left missing or &#x60;null&#x60; if no meaningful resolution exists. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

