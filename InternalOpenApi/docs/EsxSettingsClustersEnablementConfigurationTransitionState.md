# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionState
The Esx.Settings.Clusters.Enablement.Configuration.Transition.State schema contains properties that describe the latest state of transitioning a cluster to desired configuration management platform.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | **string** | Author of transition.  This property was added in __vSphere API 8.0.1.0__. | 
**StartTime** | **DateTime** | The start time of the transition process.  This property was added in __vSphere API 8.0.1.0__. | 
**ModifiedTime** | **DateTime** | Last modified time of the transition process.  This property was added in __vSphere API 8.0.1.0__. | 
**Source** | **string** | Source of reference configuration.  Possible values:   - &#x60;FILE&#x60;: This indicates that desired configuration originated from a file.   - &#x60;HOST&#x60;: This indicates that desired configuration originated from a reference host.   For more information see: *Esx.Settings.Clusters.Enablement.Configuration.Transition.Source*.  This property was added in __vSphere API 8.0.1.0__. | 
**Host** | [**EsxSettingsClustersEnablementConfigurationTransitionReferenceHost**](EsxSettingsClustersEnablementConfigurationTransitionReferenceHost.md) | Reference host.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of source is *Esx.Settings.Clusters.Enablement.Configuration.Transition.Source.HOST*. | [optional] 
**Filename** | **string** | Filename of the imported configuration.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of source is *Esx.Settings.Clusters.Enablement.Configuration.Transition.Source.FILE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

