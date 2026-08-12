# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsApplyResult
The Esx.Settings.Clusters.Configuration.Drafts.ApplyResult schema contains the result of committing a draft.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | **string** | The ID of the commit created for this operation.  This property was added in __vSphere API 8.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | 
**ApplyTask** | **string** | If the cluster is not empty, this will be set to the ID of the Apply task.  This property was added in __vSphere API 8.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

