# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsImageHostDetails
The Esx.Settings.Clusters.Software.Reports.ImageHostDetails schema contains details about the image and the list of hosts on which it will be applied.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Image** | [**EsxSettingsImageInfo**](EsxSettingsImageInfo.md) | This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; for the default image. | [optional] 
**Hosts** | **List&lt;string&gt;** | This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

