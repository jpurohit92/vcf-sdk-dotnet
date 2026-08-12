# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersInstalledImagesInstalledImage
The Esx.Settings.Clusters.InstalledImages.InstalledImage schema contains properties information about installed software image that is running on the group of hosts  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SoftwareInfo** | [**EsxSettingsSoftwareInfo**](EsxSettingsSoftwareInfo.md) | Software image installed on group of hosts  This property was added in __vSphere API 8.0.3.0__. | 
**HostList** | **List&lt;string&gt;** | List of hosts having the same software image  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

