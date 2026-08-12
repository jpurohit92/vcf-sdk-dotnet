# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareReportsLastApplyResultApplyResult
The Esx.Settings.Hosts.Software.Reports.LastApplyResult.ApplyResult schema contains properties that describe the result of an apply operation.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsHostsSoftwareReportsLastApplyResultApplyStatus**](EsxSettingsHostsSoftwareReportsLastApplyResultApplyStatus.md) | Specifies the status of the apply operation.  This property was added in __vSphere API 8.0.0.1__.  missing or &#x60;null&#x60; if the apply operation is in progress. | [optional] 
**Commit** | **string** | The identifier of the commit used to fetch the desired software document to be applied to the standalone host.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | 
**HostInfo** | [**EsxSettingsHostInfo**](EsxSettingsHostInfo.md) | Information of the host to which the desired software document specified by the *Esx.Settings.Hosts.Software.Reports.LastApplyResult.ApplyResult.commit* needs to be applied to.  This property was added in __vSphere API 8.0.0.1__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications providing additional information for *POST /esx/settings/hosts/{host}/software?action&#x3D;apply* operation. These notifications are mutually exclusive with the notifications in Esx.Settings.Hosts.Software.Reports.LastApplyResult.ApplyStatus.  This property was added in __vSphere API 8.0.0.1__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

