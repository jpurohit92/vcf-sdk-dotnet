# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOnlineUpdateSpec
The Esx.Settings.Depots.Online.UpdateSpec schema defines the information used to update the depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether this depot is enabled or not. Disabling the depot doesn&#39;t delete its cached metadata and payloads. It will not be refreshed next time depots are re-synced.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, enabled flag is not updated. | [optional] 
**Description** | **string** | Description of the depot.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, description is not updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

