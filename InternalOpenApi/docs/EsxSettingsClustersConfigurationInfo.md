# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationInfo
The Esx.Settings.Clusters.Configuration.Info schema defines the information about configuration commit.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | [**EsxSettingsClustersConfigurationMetadata**](EsxSettingsClustersConfigurationMetadata.md) | Metadata about the configuration commit.  This property was added in __vSphere API 8.0.1.0__. | 
**HostInfo** | [**Dictionary&lt;string, EsxSettingsHostInfo&gt;**](EsxSettingsHostInfo.md) | A mapping of BIOS UUIDs for every host in the cluster to information about that host. The host-specific/host-override sections of the configuration use BIOS UUIDs to identify hosts, so this information can be useful to get details about hosts mentioned there.  This property was added in __vSphere API 8.0.1.0__. | 
**Config** | **string** | Configuration specification associated with the commit, encoded as JSON.  This property was added in __vSphere API 8.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

