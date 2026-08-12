# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsUmdsUpdateSpec
The Esx.Settings.Depots.Umds.UpdateSpec schema defines the information used to update the UMDS depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether or not this depot is enabled. Disabling the depot doesn&#39;t delete its cached metadata and payloads. It will not be refreshed next time depots are re-synced.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the enabled flag is not updated. | [optional] 
**Description** | **string** | Description of the depot.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the description is not updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

