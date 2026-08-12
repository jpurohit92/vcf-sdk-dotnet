# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationSchemaResult
The Esx.Settings.Clusters.Configuration.SchemaResult schema contains properties that describe the configuration schema associated with the cluster.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | The source of this schema.  Possible values:   - &#x60;IMAGE_PROFILE&#x60;: The schema was derived from a VLCM image profile.   - &#x60;HOST&#x60;: The schema was extracted from a reference host.   For more information see: *Esx.Settings.Clusters.Configuration.SchemaResult.Source*.  This property was added in __vSphere API 8.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Schema** | **string** | The configuration schema associated with the cluster.  This property was added in __vSphere API 8.0.1.0__. | 
**ReferenceHost** | [**EsxSettingsClustersConfigurationReferenceHostInfo**](EsxSettingsClustersConfigurationReferenceHostInfo.md) | If the source of this schema was a reference, this field will be populated with the current status of the host.  This property was added in __vSphere API 8.0.3.0__.  This property is optional and it is only relevant when the value of source is *Esx.Settings.Clusters.Configuration.SchemaResult.Source.HOST*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

