# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareRecommendationsFilterSpec
The Esx.Settings.Clusters.Software.Recommendations.FilterSpec schema contains properties used to filter the generated recommendations (see *POST /esx/settings/clusters/{cluster}/software/recommendations?action=generate*) based on a specified base image version.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseImageVersion** | **string** | Base image version string is used in generating the specified base image recommendations. Default recommendations are generated when the value is empty.  This property was added in __vSphere API 7.0.2.0__. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

