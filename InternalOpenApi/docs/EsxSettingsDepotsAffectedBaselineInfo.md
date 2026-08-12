# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsAffectedBaselineInfo
The Esx.Settings.Depots.AffectedBaselineInfo schema contains the fields that describe which updates (bulletins) in the baseline will be affected by the depot to be deleted or disabled.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Baseline** | **string** | Name of the baseline affected.  This property was added in __vSphere API 7.0.3.0__. | 
**Id** | **long** | Identifier of the baseline affected.  This property was added in __vSphere API 7.0.3.0__. | 
**AffectedUpdates** | [**Dictionary&lt;string, EsxSettingsDepotsUpdateSummary&gt;**](EsxSettingsDepotsUpdateSummary.md) | Updates (bulletins) affected. They key is identifier of the update (bulletin). The value is summary of the update (bulletin).  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.depots.bulletin&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.depots.bulletin&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

