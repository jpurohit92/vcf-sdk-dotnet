# Vcenter.Automation.OpenApi.Model.EsxSettingsHardwareSupportManagersPackagesHardwareSupportPackageInfo
The Esx.Settings.HardwareSupport.Managers.Packages.HardwareSupportPackageInfo schema contains properties that describe a particular 3rd party Hardware Support Package (HSP)  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pkg** | **string** | Name of the Hardware Support Package (e.g. \&quot;Jan. 2018 Release\&quot; or \&quot;Latest Hardware Support Package for Frobozz GenX hardware\&quot;) selected  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.package&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.package&#x60;. | 
**VarVersion** | **string** | Version of the Hardware Support Package (e.g. \&quot;20180128.1\&quot; or \&quot;v42\&quot;) selected  This property was added in __vSphere API 7.0.0.0__. | 
**Description** | **string** | Description of the Hardware Support Package (HSP) (e.g. for use in help bubble)  This property was added in __vSphere API 7.0.0.0__. | 
**SupportedReleases** | **List&lt;string&gt;** | Supported vSphere releases  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

