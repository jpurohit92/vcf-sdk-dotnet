# Vcenter.Automation.OpenApi.Model.EsxHostsSoftwareInstalledComponentsInstalledComponentInfo
The Esx.Hosts.Software.InstalledComponents.InstalledComponentInfo schema contains properties that describe the installed component on the host.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**VarVersion** | **string** | Version of the installed component  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**Platforms** | **List&lt;string&gt;** | Platforms the component belongs to. Example: host, vmdpu0, vmdpu1, ...  This property was added in __vSphere API 8.0.0.1__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

