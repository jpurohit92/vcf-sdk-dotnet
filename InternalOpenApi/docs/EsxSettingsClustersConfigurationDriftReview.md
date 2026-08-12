# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDriftReview
Represents the drifts that need review.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyPaths** | **List&lt;string&gt;** | Set of property paths for the configuration which has drift and needs review. This can either be the path of a drift in cluster config which start with profile, or a drift in host-specific or host-override.  This property was added in __vSphere API 9.1.0.0__. | 
**DriftReviewPolicy** | [**EsxSettingsClustersConfigurationDriftReviewPolicy**](EsxSettingsClustersConfigurationDriftReviewPolicy.md) | The policy provided by the solution.  This property was added in __vSphere API 9.1.0.0__. | [optional] 
**Notification** | [**EsxSettingsNotification**](EsxSettingsNotification.md) | Notification that provides additional information about the drift.  This property was added in __vSphere API 9.1.0.0__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

