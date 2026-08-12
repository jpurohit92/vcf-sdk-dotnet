# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionReferenceHost
The Esx.Settings.Clusters.Enablement.Configuration.Transition.ReferenceHost contains properties that specify the reference host information used by the transition process.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | Reference host ID.  This property was added in __vSphere API 8.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 
**HostInfo** | [**EsxSettingsHostInfo**](EsxSettingsHostInfo.md) | Host Info for Reference host.  This property was added in __vSphere API 8.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

