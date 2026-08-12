# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationAvailableValuesPathInfo
The Esx.Settings.Clusters.Configuration.AvailableValues.PathInfo schema contains available values for a path.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterValues** | **string** | Available values for cluster configurations.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Configuration.AvailableValues.PathInfo.Status.OK*. | [optional] 
**HostValues** | **Dictionary&lt;string, string&gt;** | Available values per host for host specific configurations.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Configuration.AvailableValues.PathInfo.Status.OK*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**Status** | **string** | Status for an input path.  Possible values:   - &#x60;OK&#x60;: The operation completed successfully.   - &#x60;ERROR&#x60;: The operation encountered failed due to an error.   For more information see: *Esx.Settings.Clusters.Configuration.AvailableValues.PathInfo.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**Error** | [**EsxSettingsNotification**](EsxSettingsNotification.md) | Notifications for an input path.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Configuration.AvailableValues.PathInfo.Status.ERROR*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

