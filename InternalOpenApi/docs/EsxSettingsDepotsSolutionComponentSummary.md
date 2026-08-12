# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsSolutionComponentSummary
The Esx.Settings.Depots.SolutionComponentSummary schema contains fields that describe the components of solution.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReleaseDate** | **DateTime** | Release date of the component.  This property was added in __vSphere API 9.0.0.0__. | 
**VarVersion** | [**EsxSettingsDepotsComponentVersion**](EsxSettingsDepotsComponentVersion.md) | Version of the component.  This property was added in __vSphere API 9.0.0.0__. | 
**VibInformations** | [**Dictionary&lt;string, EsxSettingsDepotsVibInfo&gt;**](EsxSettingsDepotsVibInfo.md) | All the VIBs contained in the component of the metadata bundle. The key is ID of the VIB.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vib&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vib&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

