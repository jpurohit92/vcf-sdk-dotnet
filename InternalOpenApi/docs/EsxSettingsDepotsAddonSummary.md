# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsAddonSummary
The Esx.Settings.Depots.AddonSummary schema contains fields that describe the summary of an addon.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Human readable name of the addon.  This property was added in __vSphere API 7.0.3.0__. | 
**Vendor** | **string** | Vendor of the addon.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.depots.vendor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.depots.vendor&#x60;. | 
**Versions** | [**List&lt;EsxSettingsDepotsAddonVersion&gt;**](EsxSettingsDepotsAddonVersion.md) | Different versions of the addon.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

