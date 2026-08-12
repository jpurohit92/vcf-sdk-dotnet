# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareDraftsComponentsUpdateSpec
The Esx.Settings.Repository.Software.Drafts.Components.UpdateSpec schema contains properties that are specified to update list of components in the draft.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComponentsToSet** | **Dictionary&lt;string, string&gt;** | List of components to be updated. If the component already exists in the draft, the version is updated, else it is added. If a component is provided without version, then its version will be chosen based on constraints in the system.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no components will be added or updated.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | [optional] 
**ComponentsToDelete** | **List&lt;string&gt;** | List of components to be removed.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no components will be removed.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

