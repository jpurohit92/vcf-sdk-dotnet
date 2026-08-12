# Vcenter.Automation.OpenApi.Model.EsxSettingsHardwareSupportManagersHardwareSupportManagerInfo
The Esx.Settings.HardwareSupport.Managers.HardwareSupportManagerInfo schema contains properties that describe a particular 3rd party Hardware Support Manager (HSM)  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Manager** | **string** | Name of the Hardware Support Manager (HSM) (e.g. \&quot;Frobozz Hardware Support Manager\&quot;)  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.manager&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.manager&#x60;. | 
**Description** | **string** | User-intelligible description of the HSM (e.g. \&quot;Front end for Frobozz so-and-so management system\&quot;)  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayName** | **string** | UI label for HSM, derived from HSM extension&#39;s description&#39;s &#39;label&#39; field. (e.g. \&quot;Frobozz Free Management System\&quot;)  This property was added in __vSphere API 7.0.0.0__. | 
**Vendor** | **string** | Company providing the Hardware Support Manager (HSM) (e.g. \&quot;Frobozz Magic Software Company\&quot;)  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

