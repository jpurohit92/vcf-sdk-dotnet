# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsHardwareSupportManagerSummary
The Esx.Settings.Depots.HardwareSupportManagerSummary schema contains fields that describe the summary of a hardware support manager (HSM).  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | UI label for HSM, derived from HSM extension&#39;s description&#39;s &#39;label&#39; field.  This property was added in __vSphere API 7.0.3.0__. | 
**Packages** | [**Dictionary&lt;string, EsxSettingsDepotsHardwareSupportPackageSummary&gt;**](EsxSettingsDepotsHardwareSupportPackageSummary.md) | Different hardware support packages (HSP) published by the HSM. The key is name of HSP.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.package&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.setting.hardware_support.package&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

