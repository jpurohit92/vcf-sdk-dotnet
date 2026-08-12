# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsChangeDetails
The Esx.Settings.Clusters.Configuration.Drafts.ChangeDetails schema contains information about changes made in the draft when compared against the current desired document.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModifiedProperties** | [**Dictionary&lt;string, EsxSettingsClustersConfigurationDraftsModificationInfo&gt;**](EsxSettingsClustersConfigurationDraftsModificationInfo.md) | Captures the properties that were added/modified in this draft. The map keys are JSON-Pointers that refer to the properties in the draft that are modifications. The values contain information about the property and, in the case of a modification, the location of the corresponding property in the desired document.  This property was added in __vSphere API 8.0.2.0__. | 
**DeletedProperties** | [**Dictionary&lt;string, EsxSettingsClustersConfigurationDraftsDeletionInfo&gt;**](EsxSettingsClustersConfigurationDraftsDeletionInfo.md) | Captures the properties that were deleted from this draft. The map keys are JSON-Pointers that refer to the properties in the desired document that were deleted.  This property was added in __vSphere API 8.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

