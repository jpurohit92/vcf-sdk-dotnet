# Vcenter.Automation.OpenApi.Model.EsxSettingsHardwareSupportPackageInfo
The Esx.Settings.HardwareSupportPackageInfo schema contains information to describe the desired Hardware Support Package (HSP) configured for a single device or distinct group of devices (typically the OEM's, including BIOS and device firmware).  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pkg** | **string** | Identifier of Hardware Support Package (HSP) selected  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.package&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.package&#x60;. | 
**VarVersion** | **string** | Version of the Hardware Support Package (HSP) selected (e.g. \&quot;20180128.1\&quot; or \&quot;v42\&quot;)  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

