# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftsCreateSpec
The Esx.Settings.Clusters.Configuration.Drafts.CreateSpec schema contains information used when creating a draft.  This schema was added in __vSphere API 8.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | **string** | The initial configuration for the draft.  This property was added in __vSphere API 8.0.2.0__.  If not specified, the current desired configuration for the cluster will be used. | [optional] 
**ImageReferenceHost** | **string** | The host to use as the desired image for the cluster when VLCM is not in use.  This property was added in __vSphere API 8.0.3.0__.  If not specified, the previously used reference host will be carried over.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

