# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotContentAddOnsSummary
The Esx.Settings.DepotContent.AddOns.Summary schema defines the summary information regarding a OEM add-on.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.add_on&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.add_on&#x60;. | 
**DisplayName** | **string** | Display name of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Vendor** | **string** | Vendor of the OEM add-on.  This property was added in __vSphere API 7.0.0.0__. | 
**Versions** | [**List&lt;EsxSettingsDepotContentAddOnsAddOnVersionSummary&gt;**](EsxSettingsDepotContentAddOnsAddOnVersionSummary.md) | Summary information about the versions of this addon. These are sorted by the version.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

