# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationAvailableValuesInfo
The Esx.Settings.Clusters.Configuration.AvailableValues.Info schema contains available values for each input path passed to getAvailableValues API.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Results** | [**Dictionary&lt;string, EsxSettingsClustersConfigurationAvailableValuesPathInfo&gt;**](EsxSettingsClustersConfigurationAvailableValuesPathInfo.md) | Contains available values for each input path  This property was added in __vSphere API 9.1.0.0__. | 
**Hosts** | [**Dictionary&lt;string, EsxSettingsHostInfo&gt;**](EsxSettingsHostInfo.md) | A mapping of BIOS UUID to the details of the host  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**BiosUuidToHostIdMap** | **Dictionary&lt;string, string&gt;** | A mapping of BIOS UUID to host moId  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the value in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the value in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

