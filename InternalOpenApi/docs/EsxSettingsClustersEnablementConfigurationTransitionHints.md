# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionHints
The Esx.Settings.Clusters.Enablement.Configuration.Transition.Hints contains properties that specifies additional information about the transition workflow. This data should be used as guidelines throughout the transition process.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequiresReferenceHost** | **bool** | This hint indicates whether a reference host is required to transition the cluster. This hint is set to true if the framework detects that cluster is not managed by vLCM. The value does not change based on the state of the transition workflow, or the value of the reference host, or status of the reference host.  This property was added in __vSphere API 8.0.3.0__.  If field is missing or &#x60;null&#x60; then the reference host is not required. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

