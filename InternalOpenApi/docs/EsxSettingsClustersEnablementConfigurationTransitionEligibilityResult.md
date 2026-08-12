# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionEligibilityResult
This Esx.Settings.Clusters.Enablement.Configuration.Transition.EligibilityResult schema contains properties that describe the result of the eligibility checks performed on the cluster to determine if the cluster can transition to desired configuration management platform.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of eligibility checks performed on a cluster.  Possible values:   - &#x60;ELIGIBLE&#x60;: This indicates that the cluster meets all the eligibility requirements.   - &#x60;NOT_ELIGIBLE&#x60;: This indicates that the cluster does not meet the eligibility requirements.   For more information see: *Esx.Settings.Clusters.Enablement.Configuration.Transition.EligibilityResult.Status*.  This property was added in __vSphere API 8.0.1.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications providing additional information about the status of eligibility checks.  This property was added in __vSphere API 8.0.1.0__.  This field is missing or &#x60;null&#x60; when *Esx.Settings.Clusters.Enablement.Configuration.Transition.EligibilityResult.status* is ELIGIBLE. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

