# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersEnablementConfigurationTransitionEnableResult
The Esx.Settings.Clusters.Enablement.Configuration.Transition.EnableResult schema contains properties that describes the result of enabling configmanager on a cluster as part of the transition process.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of enabling configmanager on a cluster.  Possible values:   - &#x60;ERROR&#x60;: Failed to enable ConfigManager on the cluster.   - &#x60;RUNNING&#x60;: The task is in-progress.   - &#x60;SUCCESS&#x60;: ConfigMnager enabled on the cluster.   - &#x60;SUCCESS_APPLY_INITIATED&#x60;: ConfigMnager enabled on the cluster and remediation was initiated.   For more information see: *Esx.Settings.Clusters.Enablement.Configuration.Transition.EnableResult.Status*.  This property was added in __vSphere API 8.0.1.0__. | 
**Errors** | [**List&lt;EsxSettingsNotification&gt;**](EsxSettingsNotification.md) | List of errors if any.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Enablement.Configuration.Transition.EnableResult.Status.ERROR*. | [optional] 
**ApplyTaskId** | **string** | ID of the Apply task invoked once ConfigManager is enabled on the cluster.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Enablement.Configuration.Transition.EnableResult.Status.SUCCESS_APPLY_INITIATED*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

