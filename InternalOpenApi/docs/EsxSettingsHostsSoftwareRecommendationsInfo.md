# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareRecommendationsInfo
The Esx.Settings.Hosts.Software.Recommendations.Info schema defines the information about the most recent recommendation generation result.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LatestRecommendation** | [**EsxSettingsSoftwareInfo**](EsxSettingsSoftwareInfo.md) | Recommended image specification based on latest base image version.  This property was added in __vSphere API 8.0.0.1__.  missing or &#x60;null&#x60; if no recommended image based on latest base image version is available. | [optional] 
**CurrentSeriesRecommendation** | [**EsxSettingsSoftwareInfo**](EsxSettingsSoftwareInfo.md) | Recommended image specification based on latest base image patch or update of the current series.  This property was added in __vSphere API 8.0.0.1__.  missing or &#x60;null&#x60; if no recommended image based on latest base image patch or update of the current series is available. | [optional] 
**BaseImageExplanationDetails** | [**List&lt;EsxSettingsHostsSoftwareRecommendationsExplanationDetails&gt;**](EsxSettingsHostsSoftwareRecommendationsExplanationDetails.md) | Details about why some base images are excluded in latest and current series recommendations. This is not applicable for specified base image recommendations.  This property was added in __vSphere API 8.0.0.1__. | 
**CheckTime** | **DateTime** | The most recent timestamp when check for recommended image is launched.  This property was added in __vSphere API 8.0.0.1__.  missing or &#x60;null&#x60; if no recommendation check has ever been launched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

