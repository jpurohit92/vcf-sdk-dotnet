# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsUmdsSetSpec
The Esx.Settings.Depots.Umds.SetSpec schema defines the information of an UMDS depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the depot.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the description will be empty. | [optional] 
**Enabled** | **bool** | Flag indicating whether or not this depot should be enabled. Disabling the depot doesn&#39;t delete its cached metadata and payloads. It will not be refreshed next time depots are re-synced.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the depot will be enabled. | [optional] 
**Location** | **string** | Location of the depot. It should be the location to the index.xml for the depot.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

