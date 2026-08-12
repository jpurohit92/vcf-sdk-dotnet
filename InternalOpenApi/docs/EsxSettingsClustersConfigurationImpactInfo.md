# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationImpactInfo
This Esx.Settings.Clusters.Configuration.ImpactInfo schema contains properties that describes the Impact if the host is not compliant against the desired configuration.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Impact** | **string** | This field indicates the ESXi host impact or cluster solution impact on applying the desired configuration.  Possible values:   - &#x60;NO_IMPACT&#x60;: Host has no impact.   - &#x60;MAINTENANCE_MODE_REQUIRED&#x60;: Host requires maintenance mode to reach the desired state.   - &#x60;REBOOT_REQUIRED&#x60;: Host requires reboot to reach the desired state.   For more information see: *Esx.Settings.Clusters.Configuration.ImpactType*.  This property was added in __vSphere API 8.0.1.0__. | 
**Info** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This field represents the list of impact information describing the configuration changes needed on the host or for a cluster solution to reach the desired state.  This property was added in __vSphere API 8.0.1.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

