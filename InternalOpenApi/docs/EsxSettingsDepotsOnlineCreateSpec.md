# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOnlineCreateSpec
The Esx.Settings.Depots.Online.CreateSpec schema defines the information used to create a depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the depot.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the description will be empty. | [optional] 
**Location** | **string** | Location of the depot. It should be the location to the index.xml for the depot.  This property was added in __vSphere API 7.0.0.0__. | 
**Enabled** | **bool** | Flag indicating whether this depot is enabled or not. Disabling the depot doesn&#39;t delete its cached metadata and payloads. It will not be refreshed next time depots are re-synced.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the depot will be enabled. | [optional] 
**Ownerdata** | **string** | Private data saved by the *Esx.Settings.Depots.Online.Info.owner* of the depot. It is opaque to vLCM.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no ownerdata will be saved. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

