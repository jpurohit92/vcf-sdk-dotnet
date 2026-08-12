# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOnlineInfo
The Esx.Settings.Depots.Online.Info schema defines the information regarding a depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the depot. It will be an empty string if no description was provided during create.  This property was added in __vSphere API 7.0.0.0__. | 
**Location** | **string** | Location of the depot.  This property was added in __vSphere API 7.0.0.0__. | 
**Enabled** | **bool** | Flag indicating whether this depot is enabled or not.  This property was added in __vSphere API 7.0.0.0__. | 
**SystemDefined** | **bool** | Flag to indicate if the depot is system defined. System defined depot can not be deleted.  This property was added in __vSphere API 7.0.0.0__. | 
**Owner** | **string** | Name of the user creating the depot.  This property was added in __vSphere API 7.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Ownerdata** | **string** | Private data saved by the owner of depot. It is opaque to vLCM.  This property was added in __vSphere API 7.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

