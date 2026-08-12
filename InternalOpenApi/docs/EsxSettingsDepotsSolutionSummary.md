# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsSolutionSummary
The Esx.Settings.Depots.SolutionSummary schema contains fields that describe the summary of a solution.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Human readable name of the solution.  This property was added in __vSphere API 7.0.3.0__. | 
**Versions** | [**List&lt;EsxSettingsDepotsSolutionVersion&gt;**](EsxSettingsDepotsSolutionVersion.md) | Different versions of the solution.  This property was added in __vSphere API 7.0.3.0__. | 
**Components** | [**Dictionary&lt;string, EsxSettingsDepotsSolutionComponentSummary&gt;**](EsxSettingsDepotsSolutionComponentSummary.md) | All the components contained in the solution of the metadata bundle. The key is ID of component.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

