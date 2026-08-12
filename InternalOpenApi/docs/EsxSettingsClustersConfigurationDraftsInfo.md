# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsInfo
The Esx.Settings.Clusters.Configuration.Drafts.Info schema defines the information about configuration draft.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | [**EsxSettingsClustersConfigurationDraftsMetadata**](EsxSettingsClustersConfigurationDraftsMetadata.md) | Metadata about the configuration draft.  This property was added in __vSphere API 8.0.2.0__. | 
**Errors** | [**EsxSettingsClustersConfigurationDraftsValidationDetails**](EsxSettingsClustersConfigurationDraftsValidationDetails.md) | This property was added in __vSphere API 8.0.2.0__.  If set, there were validation errors detected in the draft configuration. | [optional] 
**Changes** | [**EsxSettingsClustersConfigurationDraftsChangeDetails**](EsxSettingsClustersConfigurationDraftsChangeDetails.md) | This property was added in __vSphere API 8.0.2.0__.  If set, there are changes in this draft configuration from the current desired configuration. | [optional] 
**Conflicts** | [**EsxSettingsClustersConfigurationDraftsConflictDetails**](EsxSettingsClustersConfigurationDraftsConflictDetails.md) | This property was added in __vSphere API 8.0.2.0__.  If set, there are changes in this draft configuration that conflict with changes applied by a different user. | [optional] 
**HostInfo** | [**Dictionary&lt;string, EsxSettingsHostInfo&gt;**](EsxSettingsHostInfo.md) | A mapping of BIOS UUIDs for every host in the cluster to information about that host. The host-specific/host-override sections of the configuration use BIOS UUIDs to identify hosts, so this information can be useful to get details about hosts mentioned there.  This property was added in __vSphere API 8.0.2.0__. | 
**HostIdToUuid** | **Dictionary&lt;string, string&gt;** | Map of host IDs to BIOS UUIDs.  This property was added in __vSphere API 8.0.2.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**Config** | **string** | Configuration specification associated with the draft, encoded as JSON.  This property was added in __vSphere API 8.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

